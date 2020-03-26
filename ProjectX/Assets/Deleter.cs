using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deleter : MonoBehaviour
{
    private GameObject player;
    // this the the game character
    private GameObject playerStats;
    // this gameobject takes care of the player stats such as the players health
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        // we have stored the player gameobject inside this variable
        playerStats = GameObject.Find("playerStats");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var whichLife = player.GetComponent<playerScript>().whichLife;
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            playerStats.GetComponent<playerHealth>().Health--;
            playerStats.GetComponent<playerScript>().UIhealth[whichLife].GetComponent<Image>().enabled = false;

            // then destroy the player
        }
        else {
            Destroy(collision.gameObject);
        }
    }
}
