using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    public GameObject platform;
    // this is the ground that we want to start instantiating
    [SerializeField]private int minTime, maxTime;
    // this is the maximium and minimum time before the platform is generated
    private void Start()
    {
        InvokeRepeating("GeneratePlatform", 1f, Random.Range(minTime, maxTime));
        // this will call the function Generateplatform every x seconds
        // the x seconds in the randomTime
        
    }
    private void Update()
    {
      
    }
    private void GeneratePlatform() {
        
        // this generates a time for the intervals of minTime and max Time
        Instantiate(platform, transform.position, Quaternion.identity);
        // this instantiates the platforms into the game
    }
}
