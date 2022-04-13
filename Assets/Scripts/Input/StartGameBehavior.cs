using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameBehavior : MonoBehaviour
{
   public void LoadGame()
    {
        SceneManager.LoadScene(sceneName: "SampleScene");
    }

    public void QuiteGame()
    {
        Application.Quit();
    }
}
