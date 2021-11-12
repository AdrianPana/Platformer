using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishMenu : MonoBehaviour
{


    public void Start()
    {
         
    }

    public void MainMenu()
    {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        this.gameObject.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex == 14) SceneManager.LoadScene("MainMenu");
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReplayLevel()
    {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
