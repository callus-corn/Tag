using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionNode : IBehaviourTree
{
    public string Key { get { return _key; } }
    private string _key;
    Func<bool> _action;

    public ActionNode(Func<bool> action,string key)
    {
        _action = action;
        _key = key;
    }

    public bool Excute()
    {
        return _action();
    }

}
