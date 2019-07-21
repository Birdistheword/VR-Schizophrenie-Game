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

    void Awake()
    {
        Audio = GetComponent<AudioSource>();
        // Load all Audio Clips
        randomAudios = Resources.LoadAll<AudioClip>("TestVoices");
    }

    void Update()
    {
        randomNumber = Random.Range(0, 150);
        if (randomNumber == 20 && !Audio.isPlaying) PlayRandomSound();
    }

    // Die Funktion kann aufgerufen werden von: SendEvent.cs und InteractionTrigger.cs
    // Beide haben vordefinierte Sounddateien (Spezifisch für die Aktion)
    void PlayRandomSound()
    {
        Audio.PlayOneShot(randomAudios[Random.Range(0, randomAudios.Length)]);
    }
    
   
    private void PlaySound(AudioClip audioClip)
    {
        Audio.PlayOneShot(audioClip);
    }

}
