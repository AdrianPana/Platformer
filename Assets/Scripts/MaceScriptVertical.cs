using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceScriptVertical : MonoBehaviour
{

    public float startPosY, range, speed;
    public bool movingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        startPosY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= startPosY + range) movingUp = false;
        else if (transform.position.y <= startPosY - range) movingUp = true;

        if (movingUp) moveUp();
        else moveDown();
    }

    void moveUp()
    {
        this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    void moveDown()
    {
        this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }
}
