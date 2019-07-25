using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    // Es muss eine ANzahl an AudioClips rausgesucht werden, die zum Random abspielen geeignet ist.
    AudioClip[] randomAudios;
    AudioSource Audio;
    GameObject targetObject;
    int randomNumber = 0;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        // Load all Audio Clips
        randomAudios = Resources.LoadAll<AudioClip>("Voices/Random");

    }

    void Update()
    {
        randomNumber = Random.Range(0, 200);
        if (randomNumber == 20)
        {
            PlayRandomSound();

        }
    }

    
    void PlayRandomSound()
    {
        Audio.PlayOneShot(randomAudios[Random.Range(0, randomAudios.Length)]);

    }

    // Die Funktion kann aufgerufen werden von: SendEvent.cs und InteractionTrigger.cs
    // Beide haben vordefinierte Sounddateien (Spezifisch für die Aktion)
    private void PlaySound(AudioClip audioClip)
    {
        Audio.PlayOneShot(audioClip);
    }

}
