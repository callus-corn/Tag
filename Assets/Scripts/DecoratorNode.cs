using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DecoratorNode:IBehaviourTree
{
    public string Key { get { return _key; } }
    private string _key;
    Func<bool> _condition;
    IBehaviourTree _leaf;

    public DecoratorNode(Func<bool> condition, string key,IBehaviourTree leaf)
    {
        _condition = condition;
        _key = key;
        _leaf = leaf;
    }

    public bool Excute()
    {
        if (_condition())
        {
            _leaf.Excute();
            return true;
        }
        return false;
    }
}