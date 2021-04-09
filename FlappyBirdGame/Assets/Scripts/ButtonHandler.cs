using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button startButton;
    public Button restartButton;
    public bool startGame = false;
    public bool restartGame = false;


    // Start is called before the first frame update
    void Start()
    {
        Button sButton = startButton.GetComponent<Button>();
        sButton.onClick.AddListener(StartGame);

        Button rButton = restartButton.GetComponent<Button>();
        rButton.onClick.AddListener(Restart);
    }

    //game has begun
    void StartGame()
    {
        startGame = true;
    }

    //restart scene
    public void Restart()
    {
        SceneManager.LoadScene("Scene1");
   
    }
}
