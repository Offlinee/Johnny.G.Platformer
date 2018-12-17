using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private GameObject Player;
    public float speed = 5f;
    // Use this for initialization
    void Start()
    {
        // Hittar Player
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        // Flyttar sig mot Player
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
