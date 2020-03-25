using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public int Health;
    // this refers to the health of the character
    public GameObject[] UIstats;
    // this is an array that will store the hearts indicate your health
    public int damage;
    // this is the damage that the character can take 
    public int whichLife;
    // this refers to the life ui which is been refered to
    public bool iamARespawn;
    // this checks if the character that is being controlled is a respawn
    private GameObject livesLeft;
    // these are the lives that remain
    private void Start()
    {
        Health = 3;
        // we have set the health to 3 
        if (iamARespawn == true)
        {
            if (GameObject.Find("life1") == null)
            {
                Health = 1;
            }
            if (GameObject.Find("life2") == null) {
                Health = 0;
            }
            // this checks if the alex that is being  controlled is a respawn or not
            // and assigns the appropriate health
            
        }


    }
    private void Update()
    {
        UIstats[0] = GameObject.Find("life1");
        UIstats[1] = GameObject.Find("life2");
        UIstats[2] = GameObject.Find("life3");
        // check the game for lives of the character
        if (Health == 2)
        {
            whichLife = 0;
        }
        if (Health == 1)
        {
            whichLife = 1;
        }
        if (Health == 0) {
            whichLife = 2;
        }
       // we made conditions so that the health can indirectly affect the displayed health bar
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            
            // do something here 
            // play a damage animation
           
            
        }
        if (collision.name == "GameOverChecker") {
            
            Destroy(UIstats[whichLife]);
            // if the player dies destroy one of its health bars
            
        }
    }





}
