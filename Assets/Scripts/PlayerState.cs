using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerState : MonoBehaviour
{
    public bool isHuman { get; private set; }
    public bool isIt { get; private set; }
    public bool isTauchable { get; private set; }
    Subject<bool> subject = new Subject<bool>();

    void Awake()
    {
        ToHuman();
        subject.Delay(TimeSpan.FromSeconds(2))
               .Subscribe(_ => {
                   ToIt();
                   Debug.Log("tauchable");
               });
    }

    private void ToIt()
    {
        isHuman = false;
        isIt = true;
        isTauchable = true;
    }

    public void ToHuman()
    {
        isHuman = true;
        isIt = false;
        isTauchable = false;
    }

    public void ToStay()
    {
        isHuman = false;
        isIt = true;
        isTauchable = false;
        subject.OnNext(true);
    }

}
