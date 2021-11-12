using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            player.GetComponent<PlayerController>().canJump = true;
        }

        else if (collision.collider.tag == "Platform")
        {
            player.GetComponent<PlayerController>().canJump = true;
            player.transform.SetParent(collision.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            player.GetComponent<PlayerController>().canJump = false;
        }

        else if (collision.collider.tag == "Platform")
        {
            player.GetComponent<PlayerController>().canJump = false;
            player.transform.SetParent(null);
        }
    }

}
