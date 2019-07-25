using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioVideoroom : MonoBehaviour
{
    AudioClip[] randomAudios;
    AudioSource Audio;

    int randomNumber = 0;
    bool inRoom = false;
    bool audioFix = true;

    void Start()
    {

        Audio = GetComponent<AudioSource>();
        // Load all Audio Clips
        randomAudios = Resources.LoadAll<AudioClip>("Voices/EchoStimmen");
        
    }

    void Update()
    {
        if (audioFix == true)
        {
            OnTriggerExit();
            audioFix = false;
        }
        Debug.Log(inRoom);
        if (inRoom == true)
        {
            randomNumber = Random.Range(0, 1000);
            if (randomNumber == 20)
            {
                 PlayRandomSound();
            }
        }
    }

    void PlayRandomSound()
    {
        Audio.PlayOneShot(randomAudios[Random.Range(0, randomAudios.Length)]);

    }

    private void OnTriggerEnter()
    {
        inRoom = true;
        Audio.PlayOneShot(Audio.clip);
    }

    private void OnTriggerExit()
    {
        inRoom = false;
        Audio.Stop();
    }

}
