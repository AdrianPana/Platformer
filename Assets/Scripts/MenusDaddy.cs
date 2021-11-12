using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusDaddy : MonoBehaviour
{
    public GameObject[] menus;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] DaddiesOfMenus = GameObject.FindGameObjectsWithTag("MenusDaddy");
        if (DaddiesOfMenus.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    public void ShowFinishMenu()
    {
        menus[0].SetActive(true);
    }

    public void HideFinishMenu()
    {
        menus[0].SetActive(false);
    }
}
