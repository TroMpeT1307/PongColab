using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {

    static int player1Score = 0;
    static int player2Score = 0;
    public GUISkin theSkin;


    // Update is called once per frame
    public static void Score(string wallName)
    {
        
        
        if (wallName == "rightWall")
        {
            player1Score++;

        }
        else
        {
            player2Score++;
        }

        Debug.Log("Player1: " + player1Score);
        Debug.Log("Player2: " + player2Score);
	}

    void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150-12, 20, 100,100),"" + player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150-12, 20, 100, 100), player2Score.ToString());
    }
}
