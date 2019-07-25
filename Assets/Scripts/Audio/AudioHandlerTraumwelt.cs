using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandlerTraumwelt : MonoBehaviour
{
    // Es muss eine ANzahl an AudioClips rausgesucht werden, die zum Random abspielen geeignet ist.

    AudioSource Audio;
    GameObject targetObject;
    int randomNumber = 0;

    void Start()
    {
        Audio = GetComponent<AudioSource>();

    

    }

    void Update()
    {

    }


    // Die Funktion kann aufgerufen werden von: SendEvent.cs und InteractionTrigger.cs
    // Beide haben vordefinierte Sounddateien (Spezifisch für die Aktion)
    private void PlaySound(AudioClip audioClip)
    {
        if (!Audio.isPlaying) Audio.PlayOneShot(audioClip);
    }

}
