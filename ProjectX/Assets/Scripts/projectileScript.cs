using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    private Rigidbody2D rb;
    // this a variable that will store the rigibody of the projectile
    private float force = 10f;
    public float xValue = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // we have referenced the rigid body of this.gameobject
        rb.velocity = Vector2.down * 27 * Time.deltaTime;
        // from here we make the rigid body move in a particular direction with a certain force
       
    }
    private void Update()
    {
        transform.position += (Vector3)new Vector2(xValue, 0) * force * Time.deltaTime;
        Destroy(this.gameObject, 1f);
    }
}
