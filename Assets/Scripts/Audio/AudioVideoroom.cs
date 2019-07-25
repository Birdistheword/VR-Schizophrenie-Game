using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioVideoroom : MonoBehaviour
{
    AudioClip voicesAudio, officeAudio, highAudio;
    AudioSource Audio;
    GameObject stateHandler;

    bool inRoom = false;
    bool audioFix = true;

    void Start()
    {
        stateHandler = GameObject.Find("StateHandler");
        Audio = GetComponent<AudioSource>();
        voicesAudio = Resources.Load<AudioClip>("Voices/voicesVideoRoom");
        officeAudio = Resources.Load<AudioClip>("Audiofiles/OfficeAudio");
        highAudio = Resources.Load<AudioClip>("Audiofiles/highAudio");
        // Load all Audio Clips


    }

    void Update()
    {
        if (audioFix == true)
        {
            OnTriggerExit();
            audioFix = false;
        }
        SwitchAudioClip();
    }

    private void SwitchAudioClip()
    {
        if(stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"].Equals(true))
        {
            Audio.clip = highAudio;
        }
        else if(stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"].Equals(false))
        {
            Audio.clip = officeAudio;
        }
    }


    private void OnTriggerEnter()
    {

        Audio.PlayOneShot(Audio.clip);
        Audio.PlayOneShot(voicesAudio);
        Camera.main.fieldOfView = 120F;
    }

    private void OnTriggerExit()
    {

        Audio.Stop();
        Camera.main.fieldOfView = 60F;
    }

}
