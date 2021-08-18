

using System;
using System.Collections.Generic;
using UnityEngine;

public interface IAliasMapper<I> : IAssignable
{
    //void RemoveMapping(string alias);
    //void AddMapping(string alias, string target);
    I GetMappedNode(string key);

}
public class ABRLabelAliasMapper<I> : ABRCollection, IAliasMapper<I> where I : IAssignable
{

    class StringPair : Tuple<string, string>
    {
        public StringPair(string key, string value) : base(key, value) { }
    }


    Dictionary<string, string> targetforAlias = new Dictionary<string, string>();

    Dictionary<string, I> cachedMappingsForAlias = new Dictionary<string, I>();

    Dictionary<string, HashSet<string>> aliasesForTarget = new Dictionary<string, HashSet<string>>();


    public void RemoveMapping(string alias)
    {
        if (targetforAlias.ContainsKey(alias))
        {
            string target = targetforAlias[alias];
            HashSet<string> aliasesforThisTarget = aliasesForTarget[target];
            aliasesforThisTarget.Remove(alias);
            if (aliasesforThisTarget.Count == 0)
            {
                //ABRManager.Instance.RemoveAwaitItemFromLabel(this, typeof(I), targetforAlias[alias]);
            }

            targetforAlias.Remove(alias);
            cachedMappingsForAlias.Remove(alias);
        }

    }

    public void AddMapping(string alias, string target)
    {

        RemoveMapping(alias);

        targetforAlias.Add(alias, target);

        // Store back-mapping
        HashSet<string> aliases;
        if (!aliasesForTarget.TryGetValue(target, out aliases))
        {
            aliasesForTarget[target] = (aliases = new HashSet<string>());
        }
        aliases.Add(alias);


        // See if this target already exists
        I targetNode = (I)ABRManager.Instance.FindNodeForLabel(typeof(I), target);

        if (targetNode != null)
        {
            cachedMappingsForAlias.Add(alias, targetNode);
        }
        else
        {
            //ABRManager.Instance.WatchLabel(this, typeof(I), target);
        }



    }
    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        I item = (I)(message.UpdateInfo as ABRUpdateMessage.ItemInfo).Item;

        string labelForItem = ABRManager.Instance.GetNodeLabel(item);

        if (message.Sender == null && message.Type == ABRUpdateMessage.UpdateType.ItemAdded)
        {
            // This is probably a label added alert from the ABRManager

            if (aliasesForTarget.ContainsKey(labelForItem))
            {
                var aliasesForThisItem = aliasesForTarget[labelForItem];
                foreach (var alias in aliasesForThisItem)
                {
                    cachedMappingsForAlias.Add(alias, item);

                }
            }

        }

        if (message.Sender == null && message.Type == ABRUpdateMessage.UpdateType.ItemRemoved)
        {
            // This is probably a label removed alert from the ABRManager

            if (aliasesForTarget.ContainsKey(labelForItem))
            {
                var aliasesForThisItem = aliasesForTarget[labelForItem];
                foreach (var alias in aliasesForThisItem)
                {
                    cachedMappingsForAlias.Remove(alias);
                }
            }

        }
        // By default, assume that the observers to this need to know there was an update
        if(false)Debug.Log(this + ": " + "Receiving an observation " + message.Type + "(" + message.UpdateInfo + ") " + " message - " + message.Sender + " says " + message.Message);

        if (aliasesForTarget.ContainsKey(labelForItem))
        {
            var aliasesForThisItem = aliasesForTarget[labelForItem];

            SendUpdateMessage(new ABRUpdateMessage
            {
                Type = ABRUpdateMessage.UpdateType.LabelSet,
                UpdateInfo = new ABRUpdateMessage.LabelSetInfo { LabelSet = aliasesForThisItem},
            });
        }
    }

    public I GetMappedNode(string key)
    {
        if (cachedMappingsForAlias.ContainsKey(key))
        {
            return cachedMappingsForAlias[key];
        }
        else
        {
            return default;
        }
    }
}
