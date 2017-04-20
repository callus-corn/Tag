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

    public DecoratorNode(string key,Func<bool> condition)
    {
        _key = key;
        _condition = condition;
    }

    public DecoratorNode(string key,Func<bool> condition,IBehaviourTree leaf):this(key,condition)
    {
        _leaf = leaf;
    }

    public bool Add(string key,IBehaviourTree leaf)
    {
        if (_key == key && _leaf == null)
        {
            _leaf = leaf;
            return true;
        }
        return false;
    }

    public bool Excute()
    {
        return _condition() ? _leaf.Excute() : false;
    }
}