using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeButton : MonoBehaviour
{
    public Sprite volumeOn;
    public Sprite volumeOff;

    public GameObject music;
    public GameObject sfx;

    bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Music");
        sfx = GameObject.FindGameObjectWithTag("Sounds");

    }

    // Update is called once per frame
    void Update()
    {
        if (music.GetComponent<Music>().isMuted == false) this.gameObject.GetComponent<Image>().sprite = volumeOn;
        else this.gameObject.GetComponent<Image>().sprite = volumeOff;

       /* if (isOn) this.gameObject.GetComponent<Image>().sprite = volumeOn;
        else this.gameObject.GetComponent<Image>().sprite = volumeOff;*/
    }

    public void Toggle()
    {
        music.GetComponent<Music>().isMuted = !music.GetComponent<Music>().isMuted;
        music.GetComponent<AudioSource>().mute = !music.GetComponent<AudioSource>().mute;
        sfx.GetComponent<AudioSource>().mute = !sfx.GetComponent<AudioSource>().mute;
    }

}
