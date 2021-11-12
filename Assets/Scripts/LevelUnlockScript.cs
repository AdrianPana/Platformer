using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockScript : MonoBehaviour
{
    public GameObject progressObject;
    public GameObject[] levels = new GameObject[14];

    // Start is called before the first frame update
    void Start()
    {
         progressObject = GameObject.FindWithTag("Progress");
        int progressAmount = progressObject.GetComponent<ProgressScript>().progress;


        for (int level = 0; level <= 13;level++)
        {
            if (progressAmount - 1 >= level) { 
                levels[level].GetComponent<Button>().interactable = true;
            }
            else levels[level].GetComponent<Button>().interactable = false;
        }
    }

    public void SelectLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
