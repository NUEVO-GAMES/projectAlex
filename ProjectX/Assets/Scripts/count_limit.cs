using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_limit : MonoBehaviour
{
  public int limit =0;

  
    public Score scoreup;
    private GameObject platform;

void start(){
    scoreup=FindObjectOfType<Score>();
        platform = GameObject.FindWithTag("platform");
}

      private void OnCollisionEnter2D(Collision2D other) {
         
     if((other.collider.tag == "Player")){
            scoreup.scorevalue++; 
        Debug.Log(scoreup.scorevalue);
      
         
        }
     
     } 
}
