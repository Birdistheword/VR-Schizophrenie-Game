using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class TriggerPlayVideo : MonoBehaviour
{
    public GameObject targetObject;
    GameObject StateHandler;
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
        //targetObject.SendMessage("PlayVid");
        videoPlayer.Play();
        StateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = true;
    }

    private void OnTriggerExit()
    {
        //targetObject.SendMessage("StopVid");
        if (videoPlayer.isPlaying) videoPlayer.Stop();
        StateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = false;
    }
}
