using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    public int Health = 3;
    // this is the players health stat
    public GameObject gameOverUI;
    // this is the gameObject in the game that holds the game over text 
    private GameObject player;
    // this is the character that is being controlled

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
        // we have set the variable for the player by finding it in the scene
        if (Health == -3) {

            player.GetComponent<playerScript>().UIhealth[2].GetComponent<Image>().enabled = false;
            // this will disable the last life when the players health has been depleted
            gameOverUI.SetActive(true);
            // this will display the gameover panel
            Time.timeScale = 0;
            // when the players lives have depleted then pause the game 
        }
    }
   

    

}
                    