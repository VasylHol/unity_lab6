using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            // CoinCounter.coin++;
            Destroy(gameObject);
        }
        
    }
}
