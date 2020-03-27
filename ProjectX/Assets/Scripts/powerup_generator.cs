using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_generator : MonoBehaviour
{ public GameObject lives;
    // this is the powerup that we want to start instantiating
    [SerializeField]private int minTime, maxTime;
    // this is the maximium and minimum time before the life is generated
    private void Start()
    {
        InvokeRepeating("Generatelife", 1f, Random.Range(minTime, maxTime));
        // this will call the function Generatelife every x seconds
        // the x seconds in the randomTime
        
    }
    private void Generatelife() {
        
        // this generates a time for the intervals of minTime and max Time
        Instantiate(lives, transform.position, Quaternion.identity);
        // this instantiates the lifes into the game
    }
}
