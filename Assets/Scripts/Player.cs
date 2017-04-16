using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;

public class Player : MonoBehaviour
{
    private void Start()
    {
        var tauch = GetComponent<Tauch>();
        this.OnCollisionEnterAsObservable()
            .Where(_ => gameObject.GetComponent<PlayerState>().isTauchable)
            .Where(x => x.gameObject.GetComponent<Player>() != null)
            .Select(x => x.gameObject.GetComponent<Player>())
            .Subscribe(x => tauch.It(this, x));
    }
}
