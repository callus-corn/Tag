using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour {

    public Transform target;

	void Update ()
    {
        var diff = new Vector3(0,2.0f,0);
        transform.position = target.position + diff;
	}
}
