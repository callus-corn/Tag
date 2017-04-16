using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tauch : MonoBehaviour
{
    public void It(Player taucher,Player tauchee)
    {
        var taucheeState = tauchee.gameObject.GetComponent<PlayerState>();
        var taucherState = taucher.gameObject.GetComponent<PlayerState>();
        if (taucheeState.isHuman)
        {
            taucheeState.ToStay();
            GameObject.Find("Tag").GetComponent<Tag>().target = tauchee.gameObject.transform;
            taucherState.ToHuman();
            Debug.Log("tauch! "+taucher.ToString());
        }
    }
}
