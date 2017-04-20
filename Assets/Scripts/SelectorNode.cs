using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectorNode : IBehaviourTree
{
    public string Key { get { return _key; } }
    private string _key;
    List<IBehaviourTree> _leaves = new List<IBehaviourTree>();

    public SelectorNode(string key)
    {
        _key = key;
    }

    public SelectorNode(string key, IBehaviourTree leaf):this(key)
    {
        _leaves.Add(leaf);
    }

    public bool Add(string key,IBehaviourTree leaf)
    {
        if (_key == key)
        {
            _leaves.Add(leaf);
            return true;
        }

        foreach (IBehaviourTree _leaf in _leaves)
        {
            if (_leaf.Add(key,leaf))
            {
                return true;
            }
        }

        return false;

    }

    public bool Excute()
    {
        foreach (IBehaviourTree leaf in _leaves)
        {
            if (leaf.Excute()) return true;
        }
        return false;
    }
}
