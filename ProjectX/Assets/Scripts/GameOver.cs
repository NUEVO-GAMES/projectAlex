using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour

{

    public GameObject GameOverPanel;
    // this is a variable that will hold the panel that displays gameOver

    private void Update()
    {
        if (GameObject.Find("life1")== null && GameObject.Find("life2") == null && GameObject.Find("life3")== null) {
            Time.timeScale = 0;
            // if the player has no lives pause the game
            GameOverPanel.SetActive(true);
            // display a gameover tab
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            Destroy(collision.gameObject);
            // if what the collider collides with is the player destroy the player
        }
      
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            Destroy(collision.gameObject);
            // this destroys the game object called enmy when it collides with the game over chacker
        }
        if (collision.tag == "platform")
        {
            Destroy(collision.gameObject);
            // if what the collider collides with is a platform destroy the platforms`
        }
    }




}