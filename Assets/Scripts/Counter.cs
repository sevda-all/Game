using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int voteAmount;
    Text vote;

    void Start () {
        vote = GetComponent<Text> ();
        voteAmount = 0;
    }

    void Update () {
        vote.text = "Vote: " + voteAmount;
    }
}
