using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    // we want to instantiate platforms randomly 
    public GameObject platformPrefabs;
    // i made a variable that will store the platforms
    private Vector2 randPosition;
    // we are creating a vector two that will hold a random position on the screen along the x axis and at intervals
    private int pFNperSequence;
    // this refers to the number of platforms that will be generated per sequence of the functions iteration
    private int timeIntervalPerSequence;
    // this refers to the time in which the function is iterated
    public GameObject screenLength;
    // this is transparent GameObject that fits the left of the camera length
    private float screenLengthValue;
    // this is the actual length of the screen width
    private float RandX;
    // this is the randomX position that is going to be generated
    private void Start()
    {
        screenLengthValue = screenLength.GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(screenLengthValue);
        // we have collected the actual width of the screen
        InvokeRepeating("InstantiatePlatforms", 2f, 5f);
        // this instantiates the platforms every 4 seconds
    }
    void Update()
    {
        RandPosition();
        // this generates a new postion every frame of the game

    }
    void RandPosition() {
        RandX = Random.Range((-screenLengthValue/2 + 3), (screenLengthValue / 2 - 2));
        // we set the random x value to be equal to a range between the left and right part of the script with some buffers
        randPosition = new Vector2(RandX, transform.position.y);
        // we have set the random position to have a random x values but is always on th e same point vertically
        // where they will be instantiated 
        
    }
    void InstantiatePlatforms() {
        Instantiate(platformPrefabs, randPosition, Quaternion.identity);
        // this is going to instantiate the prefabs at random points on the x axis  
    }
}
