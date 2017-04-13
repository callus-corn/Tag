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
        var random = UnityEngine.Random.Range(0, players.Count);
        players[random].GetComponent<PlayerState>().ToStay();
        GameObject.Find("Tag").GetComponent<Tag>().target = players[random].transform;
    }
}
