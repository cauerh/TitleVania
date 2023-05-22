using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int coinPickup = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            coinPickup++;
            Destroy(gameObject);
        }
    }
}