using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;

public class Player : MonoBehaviour
{
    public PlayerState state;

    private void Awake()
    {
        state = GetComponent<PlayerState>();
    }

    private void Start()
    {
        var tauch = GetComponent<Tauch>();
        this.OnCollisionEnterAsObservable()
            .Where(_ => state.isTauchable)
            .Where(x => x.gameObject.GetComponent<Player>() != null)
            .Select(x => x.gameObject.GetComponent<Player>())
            .Subscribe(x => tauch.It(this, x));
    }
}
