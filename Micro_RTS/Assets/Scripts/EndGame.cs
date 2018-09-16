using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public GameObject winBox;
    public GameObject loseBox;

    public void WinGame()
    {
        winBox.SetActive(true);
        Debug.Log("Game has ended. You Win!");
        Time.timeScale = 0;

    }

    public void LoseGame()
    {
        loseBox.SetActive(true);
        Debug.Log("Game has ended. You lose...");
        Time.timeScale = 0;


    }
}
