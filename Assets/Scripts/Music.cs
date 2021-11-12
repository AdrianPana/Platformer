using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool isMuted = false;

    private void Awake()
    {
        GameObject[] musicSources = GameObject.FindGameObjectsWithTag("Music");
        if (musicSources.Length > 1)
        { Destroy(this.gameObject); }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
