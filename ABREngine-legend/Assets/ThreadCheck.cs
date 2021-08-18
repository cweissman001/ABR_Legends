using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThreadCheck : MonoBehaviour
{
    static Thread mainThread = Thread.CurrentThread;

    static public bool IsMainThread()
    {
        return Thread.CurrentThread == mainThread; 
    }
}
