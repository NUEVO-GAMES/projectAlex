using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
  
    public GameObject[] UIhealth;
    // this is the graphical representation of the characters health
    // Start is called before the first frame update
    public int whichLife;
    private GameObject playerStats;
    void Start()
    {
        playerStats = GameObject.Find("playerStats");
        // we have gotten the gameobject of the characters stats
        UIhealth[0] = GameObject.Find("life1");
        UIhealth[1] = GameObject.Find("life2");
        UIhealth[2] = GameObject.Find("life3");
        // here we look for things in the scene with the names life1 life2 and life3 
        // and then we assign it to the contents of the array made accordingly
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.GetComponent<playerHealth>().Health == 3)
        {
            whichLife = 3;
        }
        if (playerStats.GetComponent<playerHealth>().Health == 2) {
            whichLife = 0;
        }
        if (playerStats.GetComponent<playerHealth>().Health == 1)
        {
            whichLife = 1;
        }
        if (playerStats.GetComponent<playerHealth>().Health == 0)
        {
            whichLife = 2;
        }

        UIhealth[whichLife].GetComponent<Image>().enabled = false;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(collision.CompareTag("lives"))
        {
            // if the player collides with a health power up
            Destroy(collision.gameObject);
            // destroy the health powerup 
            playerStats.GetComponent<playerHealth>().Health++;
            //increase the health of the player by one
            UIhealth[whichLife].GetComponent<Image>().enabled = true;

        }
    }
}
