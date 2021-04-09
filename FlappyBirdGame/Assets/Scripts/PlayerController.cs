using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rBody;
    public ButtonHandler buttonAction;
    public TextBehavior textScript;
    public bool playerDeath = false;
    public bool playerWin = false;
    

    // Start is called before the first frame update
    void Start()
    {
        //disable rigidbody physics before game starts so player does not fall immediately off screen
        rBody.bodyType = RigidbodyType2D.Kinematic;
        Debug.Log("It's working!");
    }

    // Update is called once per frame
    void Update()
    {
        //check if game has began
        if (buttonAction.startGame == true)
        {
            //turn on rigidbody physics and begin game
            rBody.bodyType = RigidbodyType2D.Dynamic;
            PlayerInput();
            PlayerMovement();
        }
        //stop the player rigid body physics if they have won
        if (playerWin == true)
        {
            rBody.bodyType = RigidbodyType2D.Static;
        }
        else if (playerDeath == true)
        {
            rBody.bodyType = RigidbodyType2D.Static;
        }

 
    }

    //check the player input
    void PlayerInput()
    {
        //if the player hits space
        if(Input.GetKey(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            //add upward momentum
            rBody.AddForce(Vector2.up * 50);
        }
    }

    //player forward momentum
    void PlayerMovement()
    {
        //move the player foward overtime
        rBody.AddForce(Vector2.right * 20 *Time.deltaTime);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //if the object being collided into has a "Danger" tag destroy rigidbody object
        if (collision.gameObject.tag == "Danger")
        {
            playerDeath = true;
           
        }
        //else if the victory barrier is hit set win game to true
        else if(collision.gameObject.tag == "Victory")
        {
            playerWin = true;
        }

    }

   

    //similar to Start 
    //initializes variables and/or states before the game starts; called once
    //best used to set up different references between scripts and Start to pass info back and forth
    /*void Awake()
    {

    }*/


}
