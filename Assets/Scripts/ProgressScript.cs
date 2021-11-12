using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressScript : MonoBehaviour
{

    public int progress = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] progressObjects = GameObject.FindGameObjectsWithTag("Progress");
        if (progressObjects.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }


}
