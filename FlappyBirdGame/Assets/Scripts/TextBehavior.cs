using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour
{
    public bool gameBegan = false;
    public PlayerController hasDied;
    public ButtonHandler buttonAction;
    public GameObject startButton;
    public GameObject restartButton;


    // Update is called once per frame
    void Update()
    {
        //calls appropriate text based on the game status
        if (buttonAction.startGame == true)
        {
            PlayerStatus();
            
        }
        if(hasDied.playerDeath == true)
        {
            DeathText();
        }
        if(hasDied.playerWin == true)
        {
            WinText();
        }
    }

    //starts the game when this method is called
    //ButtonHandler now handles this
    /*public void ClickToStart()
    {
        gameBegan = true;
        GameObject startButton = GameObject.Find("StartButton");
        startButton.SetActive(false);
    }*/

    //displays no text while game is running
    void PlayerStatus()
    {
        Text displayText = this.gameObject.GetComponent<Text>();
        displayText.text = " ";
        startButton.SetActive(false);
    }

    //displays the death text if the player loses
    void DeathText()
    {
        Text displayText = this.gameObject.GetComponent<Text>();
        displayText.text = "You Have Died! Try Again!";
        restartButton.SetActive(true);
    }

    //displays the victory text if the player wins
    void WinText()
    {
        Text displayText = this.gameObject.GetComponent<Text>();
        displayText.text = "You Won! Click to Play Again!";
        restartButton.SetActive(true);
    }
}
