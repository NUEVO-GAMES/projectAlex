using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //score variable used for the score system initialized at a value of 0
     public float scorevalue=0f;

     //the text (scoretext) element that will help display the current score to the screen
   public Text scoretext;

   //the text (hiscore) element that will help display the current hiscore to the screen
    public Text hiscore;


        void Update()
    {   
      
        //setting the score text to match the value of score value as a string
        scoretext.text = scorevalue.ToString();

        //Logic to ensure the highscore only updates when scorevalue is at its highest
        if (scorevalue > PlayerPrefs.GetFloat("Hiscore", 0f))
    //this line is to change the value of the playerprefs variable eg.Playerprefs.Set[variabletype](1st parameter is the name of the playerprefs variable, 2nd parameter is the modified value)
       { PlayerPrefs.SetFloat("Hiscore", scorevalue);
        //setting the hiscore text to match the value of hiscore value as a string
            hiscore.text = "BEST:" + scorevalue;
       }
    }


    void Start()
    {
    //this line is setting the hiscore text to match a playerprefs float named "Hiscore" and giving it a default value of 0f ==>Playerprefs.Get[variabletype](1st parameter is the name of the playerprefs variable. 2nd parameter is the initial value)
     hiscore.text = "BEST:" + PlayerPrefs.GetFloat("Hiscore", 0f);
    }

    // Update is called once per frame


  
}
