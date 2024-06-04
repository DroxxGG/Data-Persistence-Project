using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerName : MonoBehaviour
{
    public GameObject startButton;
    public static string playerName;


    public void ReadNameInput(string n)
    {

        playerName = n;
        Debug.Log("Player name set as: " + playerName);

        if (playerName != "")
        {
            startButton.SetActive(true);
        }
        else
        {
            startButton.SetActive(false);
        }
    }
}
