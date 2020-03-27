using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkClosestToGround : MonoBehaviour
{
    // we want to respawn a character on the transform of a platform after he fails
    public GameObject player;
    // we have made a variable that will store the player in it
    [SerializeField]private float distance;
    // this is going to store the distance between the platform and the refernce ground
    private GameObject Deleter;
    // this is a variable that will hold the deleter gameObject
    private void Start()
    {
        Deleter = GameObject.Find("GameOverChecker");
        // we have stored the the gameobject game over checker because we want to access the boolean gone through
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (Deleter.GetComponent<Deleter>().goneThrough == true && collision.CompareTag("platform")) {
            Deleter.GetComponent<Deleter>().goneThrough = false;
            player.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 0.6f);
        }
    }
}
