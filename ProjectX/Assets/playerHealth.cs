using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    public int Health = 3;
    // this is the players health stat
    public GameObject healthPanel;
    private GameObject player;


    private void Update()
    {
        player = GameObject.FindWithTag("Player");
        if (Health == 0) {

            player.GetComponent<playerScript>().UIhealth[2].GetComponent<Image>().enabled = false;
            StartCoroutine("endScreenWait");
            

        }
    }
    IEnumerator endScreenWait() {
        yield return new WaitForSeconds(0f);
        healthPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
