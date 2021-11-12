using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip winSound, deathSound, coinSound;
    static AudioSource audioSrc;

    void Awake()
    {
        GameObject[] sfxSources = GameObject.FindGameObjectsWithTag("Sounds");
        if (sfxSources.Length > 1)
        { Destroy(this.gameObject); }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        winSound = Resources.Load<AudioClip>("win");
        deathSound = Resources.Load<AudioClip>("death");
        coinSound = Resources.Load<AudioClip>("coin");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "win":
                audioSrc.PlayOneShot(winSound);
                break;

            case "death":
                audioSrc.PlayOneShot(deathSound);
                break;

            case "coin":
                audioSrc.PlayOneShot(coinSound);
                break;

        }
    }
}
