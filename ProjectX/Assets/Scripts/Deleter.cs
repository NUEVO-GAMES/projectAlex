using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deleter : MonoBehaviour
{public bool issheild= false;
    
    private GameObject player;
    // this the the game character
    private GameObject playerStats;
    // this gameobject takes care of the player stats such as the players health
    public bool goneThrough = false;
    // this is a boolean that checks if the player has gone through the deleter collider
   
   
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        // we have stored the player gameobject inside this variable
        playerStats = GameObject.Find("playerStats");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var whichLife = player.GetComponent<playerScript>().whichLife;
        if (collision.CompareTag("Player")&& issheild==false)
        {
            goneThrough = true;
            playerStats.GetComponent<playerHealth>().Health--;
            playerStats.GetComponent<playerScript>().UIhealth[whichLife].GetComponent<Image>().enabled = false;

            // then destroy the player
        }
         if (collision.CompareTag("Player")&&issheild==true)
        {
            goneThrough = true;
            issheild=false;
            // then destroy the player
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy") || collision.CompareTag("platform"))
        {
            Destroy(collision.gameObject);
        }
    }
}
