using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeToGround : MonoBehaviour
{
    // in this script we are going to calculate the distance between the game object and the ground along the y axis
    [SerializeField] private float displacement;
    // this is the distance between the ground and the platform on the y axis;
    public GameObject referenceGround;
    // this is the ground we refer to in this script
    void Update()
    {
        displacement = transform.position.y - referenceGround.transform.position.y;
        // we have obtained the distance between them
        if (displacement < 0) {
            displacement = displacement * -1;
        }
        // this means the displacement value will on give and absolute number
    }
}
