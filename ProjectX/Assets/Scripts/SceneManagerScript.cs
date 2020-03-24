using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public bool isLoadingScene;

    void Update()
    {
        if (isLoadingScene == true) {
            StartCoroutine(toMainMenu());
        }
       
    }
      
    IEnumerator toMainMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("mainMenu");
    }
    public void toPlayScene()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void toModeSelection()
    {
        SceneManager.LoadScene("modeSelection");
    }

}
