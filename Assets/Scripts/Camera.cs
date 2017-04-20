using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    [SerializeField]
    public Transform target;

	void Update ()
    {
        var diff = new Vector3( 0, 2.0f, -3.0f);
        var rotation = new Vector3(15,0,0);
        transform.position = target.position + diff;
        transform.eulerAngles = rotation;
	}
}
