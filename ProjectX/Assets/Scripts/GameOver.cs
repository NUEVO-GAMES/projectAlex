using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
  
    public GameObject UIpanel;
    // we made a variable to store the UI panel so we can do operations on it
    private GameObject platforms;
    // here we have made a private variable that will store the game object the platforms in which the players and the enemy
    public GameObject[] lifeUI;
    // we have made a list that contains the characters health
    // stand on
    private int Health = 3;
    // this refers to the life bars
    private void Start()
    {
        
        platforms = GameObject.FindGameObjectWithTag("platform");
        // we have set all game objects with the tag platform to this variable;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            Destroy(collision.gameObject);
            Health--;
            lifeUI[(2 - Health)].SetActive(false);
            // when the player falls through the game the players health is reducing
        }
        if (Health == 0) {
            UIpanel.SetActive(true);
            Time.timeScale = 0f;
            // when the health of the player is zero we want to bring up the game over panel
            // pasue the game 
        }
       
        // here we want to check the nearest platform to the player before he falls through the game
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "platform") {
            Destroy(collision.gameObject);
        }
        // we have made an if statement that checks if the collided objcet is the object platform as its tag and destroys them 
        // when it exits the trigger
        if (collision.name == "Enemy1")
        {
            Destroy(collision.gameObject);
        }
    }
   
}
