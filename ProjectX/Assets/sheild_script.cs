using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheild_script : MonoBehaviour
{
    public SpriteRenderer sheildsprite;
   public CircleCollider2D sheildcol;
    Deleter Deleter;
    // Start is called before the first frame update
    void Start()
    {
        sheildsprite = GetComponent<SpriteRenderer>();
        sheildcol = GetComponent<CircleCollider2D>();
        Deleter=FindObjectOfType<Deleter>();
    }

    void Update() {
        if(Deleter.issheild == true){
            sheildcol.enabled=true;
            sheildsprite.enabled=true;
        }
        else{
            sheildcol.enabled=false;
            sheildsprite.enabled=false;
        }
    }

   

    
}
