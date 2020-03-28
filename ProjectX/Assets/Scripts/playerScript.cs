using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    Deleter Deleter;

   
  
    public GameObject[] UIhealth;
    // this is the graphical representation of the characters health
    // Start is called before the first frame update
    public int whichLife;
    // this is an integer variable that will control UIhealth visibility
    private GameObject playerStats;
    // this will hold the empty game object in the scene that holds the Health value
    void Start()
    {
        playerStats = GameObject.Find("playerStats");
        // we have assigned the variable player stats to the empty gameobject we talked about above
        Deleter=FindObjectOfType<Deleter>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (playerStats.GetComponent<playerHealth>().Health == 3) {
            whichLife = -3;
        }
        if (playerStats.GetComponent<playerHealth>().Health == 1)
        {
            whichLife = 0;
        }
        if (playerStats.GetComponent<playerHealth>().Health == -1)
        {
            whichLife = 1;
        }
        if (playerStats.GetComponent<playerHealth>().Health == -3)
        {
            whichLife = 2;
        }
        // these are control statements that were made to counter unitys bug on addition and subtration operations on the health
        // its a bit complicated its a bug control

        UIhealth[whichLife].GetComponent<Image>().enabled = false;
        // this checks every frame in which the game is running for the whichLife variable which tells it which heart to disable
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(collision.CompareTag("lives"))
        {
            // if the player collides with a health power up
            Destroy(collision.gameObject);
            // destroy the health powerup 
            if (playerStats.GetComponent<playerHealth>().Health < 3)
            { playerStats.GetComponent<playerHealth>().Health += 1; }
            //increase the health of the player by one if the health of the player is less than 3 which is the max health
            UIhealth[whichLife].GetComponent<Image>().enabled = true;
            // this enables the image script of the UI element 

        }
        if (collision.CompareTag("enemy")&& Deleter.issheild==false) {
            playerStats.GetComponent<playerHealth>().Health--;
        }
        // the checks if what is colliding with the player has a tag called enemy
        // if so then it damages the player
        
        if (collision.CompareTag("enemy")&& Deleter.issheild==true) {
             Destroy(collision.gameObject);
        }

        if(collision.tag=="sheildPU"){
            Deleter.issheild=true;
             Destroy(collision.gameObject);
            Invoke("sheildoff",10f);
        }
    }

    public void sheildoff(){Deleter.issheild=false;}
}
