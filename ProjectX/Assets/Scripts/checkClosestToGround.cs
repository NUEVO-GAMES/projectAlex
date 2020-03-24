using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkClosestToGround : MonoBehaviour
{
    // we want to respawn a character on the transform of a platform after he fails
    public GameObject playerPrefab;
    // we have made a variable that will store the player in it
    [SerializeField]private float distance;
    // this is going to store the distance between the platform and the refernce ground
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (GameObject.FindWithTag("Player") == false && collision.tag == "platform") {
            Instantiate(playerPrefab, new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + distance), Quaternion.identity);
        }
        // here when the collision checks to be the platform and the character is not in the game 
    // we instantiate the player back into the game and place it at the position of the nearest platform
    }
}
