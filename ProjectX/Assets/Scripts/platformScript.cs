using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour
{/* we want to make the platforms move down in the game slowly*/
    private Rigidbody2D rb;
    // we have made a variable rb that will store the rigid body of the platforms
    public float fallSpeed;
    // this is the speed at which the platforms move down
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // we have collected the rigidbody of the platforms 
        rb.gravityScale = 0f;
        // this disables the gravity on the platforms we do not want the platforms we want them to maove at a steady speed

    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.down * fallSpeed * Time.deltaTime;
        // this enables the platforms to move down
    }
}
