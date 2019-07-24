using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class TriggerPlayVideo : MonoBehaviour
{
    public GameObject targetObject, StateHandler;
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = targetObject.GetComponent<VideoPlayer>();
        StateHandler = GameObject.Find("StateHandler");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        Debug.Log("Send Event PlayVid");
        //targetObject.SendMessage("PlayVid");
        videoPlayer.Play();
        StateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = true;
    }

    private void OnTriggerExit()
    {
        Debug.Log("Send Event PlayVid");
        //targetObject.SendMessage("StopVid");
        if (videoPlayer.isPlaying) videoPlayer.Stop();
        StateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = false;
    }
}
