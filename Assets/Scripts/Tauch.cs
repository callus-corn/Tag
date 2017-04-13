using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tauch : MonoBehaviour
{
    public void It(Player taucher,Player tauchee)
    {
        if (tauchee.state.isHuman)
        {
            tauchee.state.ToStay();
            GameObject.Find("Tag").GetComponent<Tag>().target = tauchee.gameObject.transform;
            taucher.state.ToHuman();
            Debug.Log("tauch! "+taucher.ToString());
        }
    }
}
