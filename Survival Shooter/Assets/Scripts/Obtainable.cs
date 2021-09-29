using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtainable : MonoBehaviour
{
    private PlayerHealth player;
    private PlayerMovement move;
    public int amount = 3;
    public float amounts = 5f;

    private void Start()
    {
        player = GetComponent<PlayerHealth>();
        move = GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(gameObject.tag == "Health")
            {
                player.Heal(amount);
            }
            if (gameObject.tag == "Speed")
            {
                move.increasespeed(amounts);
            }
        }
    }
}
