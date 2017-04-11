using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        var players = new List<GameObject>();
        players.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        players[UnityEngine.Random.Range(0, players.Count)].GetComponent<Player>().state.ToStay();
    }
}
