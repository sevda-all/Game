using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vote : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if (col.name == "trump"){
            Counter.voteAmount += 100;
            Destroy(gameObject);
        }
    }

}
