using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private List<GameObject> players = new List<GameObject>();
    private float delta=0;

    private void Start()
    {
        players.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        foreach (GameObject x in players)
        {
            x.GetComponent<Player>().onTauch += OnTouch;
        }
        players[Random.Range(0, players.Count)].tag = "It";
    }

    private void Update()
    {
        delta += Time.deltaTime;
    }

    private void OnTouch(GameObject taucher,GameObject tauchee)
    {
        if (delta>=3.0)
        {
            taucher.tag = "Player";
            tauchee.tag = "It";
            delta = 0;
        }
    }
}
