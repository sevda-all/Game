using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForWin : MonoBehaviour
{
    public GameObject winUI;

    void Update () {
        if (Counter.voteAmount == 18500)
            WinTab();
    }

    public void WinTab(){
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
