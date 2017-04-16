using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;

public class PlayerMover : MonoBehaviour {

	void Start ()
    {
        var input = GetComponent<IInputProvider>();
        var animator = GetComponent<Animator>();

        input.MoveDirection
             .Subscribe(move =>{
                 var turn = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg - transform.localEulerAngles.y;
                 transform.Rotate(0, turn , 0);
                 animator.SetFloat("Run", move.magnitude);
             });
	}
}
