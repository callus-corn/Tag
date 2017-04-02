using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public event Action<GameObject,GameObject> onTauch = delegate { };

    private void OnCollisionEnter(Collision collision)
    {
        if (this.tag.Contains("It"))
        {
            if (collision.gameObject.tag.Contains("Player"))
            {
                onTauch(this.gameObject, collision.gameObject);
            }
        }
    }
}
