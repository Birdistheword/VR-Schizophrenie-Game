using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class TriggerPlayVideo : MonoBehaviour
{
    public GameObject targetObject;
    public VideoClip officeVideo;
    GameObject stateHandler;
    private VideoPlayer videoPlayer;


    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = targetObject.GetComponent<VideoPlayer>();
        stateHandler = GameObject.Find("StateHandler");
        OnTriggerExit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        //targetObject.SendMessage("PlayVid");
        if (videoPlayer.clip != officeVideo) videoPlayer.clip = officeVideo;
        videoPlayer.Play();
        stateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = true;

        // Andere Stimmen aka. Audiohandler ausschalten



        

    }

    private void OnTriggerExit()
    {
        //targetObject.SendMessage("StopVid");
        if (videoPlayer.isPlaying) videoPlayer.Pause();
        stateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"] = false;
        stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"] = false;

    }
}
