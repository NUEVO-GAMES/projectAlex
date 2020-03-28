using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{


    Deleter Deleter;
    // we want the enemy to patrol on the platform which its on
    private float platformLength;
    // this is the total length of the platform in which the enemy is on 
    private GameObject platform;
    // this refers to the platform in which the enemy is on
    private Vector2 distanceOnPlatform;
    // this is the direction the enmey is moving on the platform
    [SerializeField] private float speed = 1f;
    // this is the interpolation position
  
    private void Start()
    {
     Deleter=FindObjectOfType<Deleter>();
    }
    void Update()
    {
       
        patrol();
        // here we have declared the patrol function
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "platform") {
            platform = collision.gameObject;
            // we have declared the platform object to any objcet that collides with the collider with the nameplatform
            platformLength = platform.GetComponent<SpriteRenderer>().bounds.size.x;
            // we have defined the float platformLenth to the length of the platform the enemy is on
        }

         if(collision.tag=="shield"){
            Deleter.issheild=false;
           
            }
    }
    void patrol() {
        transform.position +=  (Vector3)new Vector2(speed, 0f) * Time.deltaTime;
        // we have set the transform along the x axis to change with an increment of speed
        if (transform.position.x >= platform.transform.position.x + platformLength / 2)
        {
            speed = speed * -1;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x <= platform.transform.position.x - platformLength / 2 && speed < 0f ) {
            speed = speed * -1;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        // the two if statements make the enemy move back anf front on the platform
    }
    

}
