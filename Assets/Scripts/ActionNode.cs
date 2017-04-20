using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionNode : IBehaviourTree
{
    public string Key { get { return _key; } }
    private string _key;
    Func<bool> _action;

    public ActionNode(string key, Func<bool> action)
    {
        _key = key;
        _action = action;
    }

    public bool Add(string key,IBehaviourTree leaf)
    {
        return false;
    }

    public bool Excute()
    {
        return _action();
    }

}
