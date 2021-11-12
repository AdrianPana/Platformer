using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public Text coinsNeededText;
    public int coinsNeeded;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       // this.gameObject.tag = "Door";
    }

    // Update is called once per frame
    void Update()
    {
       coinsNeededText.text = coinsNeeded.ToString();

        if (player.GetComponent<PlayerController>().score == coinsNeeded) this.gameObject.tag = "Door";
    }
}
