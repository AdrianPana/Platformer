using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceScript : MonoBehaviour
{

   public float startPosX, range, speed;
    public bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        startPosX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= startPosX + range) movingRight = false;
        else if (transform.position.x <= startPosX - range) movingRight = true;

        if (movingRight) moveRight();
        else moveLeft();
    }

    void moveRight()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void moveLeft()
    {
        this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
