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
        if (inRoom == true)
        {
            randomNumber = Random.Range(0, 500);
            if (randomNumber == 20)
            {
                 PlayRandomSound();
                Debug.Log("Random Echo Sound Played");
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
        Camera.main.fieldOfView = 120F;
    }

    private void OnTriggerExit()
    {
        inRoom = false;
        Audio.Stop();
        Camera.main.fieldOfView = 60F;
    }

}
