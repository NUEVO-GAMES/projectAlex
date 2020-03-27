using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject projectile;
    // this is the attack of the enemy
    // we want the enemy to patrol on the platform which its on
    private float platformLength;
    // this is the total length of the platform in which the enemy is on 
    private GameObject platform;
    // this refers to the platform in which the enemy is on
    private Vector2 distanceOnPlatform;
    // this is the direction the enmey is moving on the platform
    [SerializeField] private float speed = 1f;
    // this is the interpolation position
    [SerializeField]private RaycastHit2D ray;
    // we have made a variable of type ray cast
    //private Vector2 viewPointPos;
    // this will store which side the ray should face
    public LayerMask playerLayer;
    // this is the layermask the player is on
    private Vector2 bulletPath;
    // this is the direction in which the 
    [SerializeField] private float distance = 0.8f;
    public bool Right;
    // to distinguish between the rights and left of the enemys 
    [SerializeField] float rot;
    private void Start()
    {
     
    }
    void Update()
    {
        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            bulletPath = Vector2.right;
        }
        else {
            bulletPath = Vector2.left;
        }
        ray = Physics2D.Raycast(transform.position, bulletPath, distance, playerLayer);
        // this sets the ray to originate from the center of the enemy  and move to the 

        if (Right == false) {
            rot = 180f;
            projectile.GetComponent<projectileScript>().xValue = 1;
        }
        else { rot = 0f;
            projectile.GetComponent<projectileScript>().xValue = -1;
        }
        patrol();
        // here we have declared the patrol function
        if (ray.collider != null) {

            attackMode();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "platform") {
            platform = collision.gameObject;
            // we have declared the platform object to any objcet that collides with the collider with the nameplatform
            platformLength = platform.GetComponent<SpriteRenderer>().bounds.size.x;
            // we have defined the float platformLenth to the length of the platform the enemy is on
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

    void attackMode() 
    {
        if (GameObject.FindWithTag("attack")== null) { Instantiate(projectile, transform.position, new Quaternion(0, rot, 0, 0)); }
        // this will instantiate the attack of the enemy
    }


}
