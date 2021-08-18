using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABRUpdateMessage
{
    public enum UpdateType
    {
        Unknown,
        InputChanged,
        ComputeUpdateFinished,
        ItemAdded,
        ItemRemoved,
        ItemUpdated,
        Deleted,
        LabelSet,
    }

    public class Info { }
    public class InputChangedInfo :Info
    {
        public System.Reflection.FieldInfo InputField { get; set; }
        public IAssignable OldAssignable { get; set; }
        public IAssignable NewAssignable { get; set; }
    }
    public class ItemUpdatedInfo : Info
    {
        public ABRUpdateMessage ItemUpdateMessage { get; set; }
    }
    public class LabelSetInfo : Info
    {
        public HashSet<string> LabelSet { get; set; }
    }
    public class ItemInfo : Info
    {
        public IAssignable Item { get; set; }
    }

    public UpdateType Type { get; set; }
    public ABRNode Sender { get; set; }
    public string Message { get; set; }
    public Info UpdateInfo { get; set; }
}



public class ObserverNode : IObservable<ABRUpdateMessage>, IObserver<ABRUpdateMessage>
{

    class Unsubscriber : IDisposable
    {
        private IObserver<ABRUpdateMessage> observer;
        private IList<IObserver<ABRUpdateMessage>> observers;
        public Unsubscriber(IList<IObserver<ABRUpdateMessage>> observers, IObserver<ABRUpdateMessage> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }


    ABRNode targetObject;
    ReceiveMessageDelegate receiveMessage;


    Dictionary<object, IDisposable> unsubscribers = new Dictionary<object, IDisposable>();

    public delegate void ReceiveMessageDelegate(ABRUpdateMessage message);

    public ObserverNode(ABRNode target, ReceiveMessageDelegate receiveMessageMethod)
    {
        targetObject = target;
        receiveMessage = receiveMessageMethod;
    }


    public void PassMessage(ABRUpdateMessage message)
    {
        var observers = new Queue<IObserver<ABRUpdateMessage>>();
        foreach(var observer in Observers)
        {
            observers.Enqueue(observer);
        }
        while (observers.Count > 0)
        {
            observers.Dequeue().OnNext(message);
        }
        ABRManager.Instance.MarkStateChanged();
    }


    public void Unsubscribe(object key)
    {
        if (unsubscribers.ContainsKey(key))
        {
            unsubscribers[key].Dispose();
            unsubscribers.Remove(key);
        }
        else
        {
            // This is fine, it just means we're clearing the subscription just in case!

            //Debug.LogError("Not currently subscribed to anything at the field " + inputField.Name);
        }

    }


    public void SubscribeTo(IObservable<ABRUpdateMessage> observable, object key)
    {
        if (observable == null)
        {
            // Just cleared out a field, nothing new to subscribe to. 
            return;
        }
        if (!unsubscribers.ContainsKey(key))
        {
            unsubscribers[key] = Register(observable);
        }
    }

    protected IDisposable Register(IObservable<ABRUpdateMessage> subject)
    {
        return subject.Subscribe(this);
    }

    #region IObservable Implementation

    IList<IObserver<ABRUpdateMessage>> _observers;
    public IList<IObserver<ABRUpdateMessage>> Observers
    {
        get { if (_observers == null) _observers = new List<IObserver<ABRUpdateMessage>>(); return _observers; }
    }

    IDisposable IObservable<ABRUpdateMessage>.Subscribe(IObserver<ABRUpdateMessage> observer)
    {

        if (!Observers.Contains(observer))
        {
            Observers.Add(observer);
        }
        return new Unsubscriber(Observers, observer);
    }

    #endregion


    #region IObserver Implementation

    void IObserver<ABRUpdateMessage>.OnCompleted()
    {
        // On Completed
    }

    void IObserver<ABRUpdateMessage>.OnError(Exception error)
    {
        // On Error
    }

    void IObserver<ABRUpdateMessage>.OnNext(ABRUpdateMessage value)
    {
        receiveMessage(value);
    }


    #endregion
}
