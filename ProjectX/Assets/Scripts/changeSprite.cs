using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class changeSprite : MonoBehaviour
{

    //what i want to do
    /*We want to make the sprite (Image) in the main menu scene change every time it is loaded*/
    // REFERENCE : unity scripting API
    public Sprite[] characters;
    // declared a variable that will store the sprites in a list
    int spriteNumber = 1;
    /* declared a sprite that will hold numbers
     these numbers will represent the sprites */
  
 
    public GameObject BG;
    // we just declared a variable that holds the gameObjects (background image)

    private void Awake()
    {
        generateRandNumber();
        // we have declared the random number generator in the awake function so it is present in the game
    }
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = characters[spriteNumber];
        // we set the sprite of the gameobject to change with the number generated in the generateRandNumber function
    }

    void generateRandNumber() {
        spriteNumber = Random.Range(0, 3);
    }
    /* we made a function that would generate random integers from 1 to 3 */
    void Update()
    {
       
      
    }
  
}
