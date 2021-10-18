using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip backgroundMusic, holeSound;

    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = Resources.Load<AudioClip>("bgm");
        holeSound = Resources.Load<AudioClip>("Hole");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string clip)
    {
        switch (clip) 
        {
            case "bgm":
            audioSource.PlayOneShot(backgroundMusic);
            break;

            case "Hole":
            audioSource.PlayOneShot(holeSound);
            break;
        }
        
    }
}
