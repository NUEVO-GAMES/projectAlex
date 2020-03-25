using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    
     public float scorevalue;
   public Text scoretext;
    public Text hiscore;
    void Start()
    {
        
     hiscore.text = "BEST:" + PlayerPrefs.GetFloat("Hiscore", 0f);
    }

    // Update is called once per frame
    void Update()
    {   
      

        scoretext.text = scorevalue.ToString();
        if (scorevalue > PlayerPrefs.GetFloat("Hiscore", 0f))
       { PlayerPrefs.SetFloat("Hiscore", scorevalue);
            hiscore.text = "BEST:" + scorevalue;
       }
    }



  
}
