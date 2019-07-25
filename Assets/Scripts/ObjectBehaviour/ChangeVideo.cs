using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{

    VideoPlayer videoPlayer;
    public VideoClip videoHigh;
    GameObject player, stateHandler;

    float distance = 40F;
    bool hasPlayer = false;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
        stateHandler = GameObject.Find("StateHandler");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        ChangeVideoWhenTakingPills();

        if (stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"].Equals(false))
        {
            if (stateHandler.GetComponent<StateHandler>().AllBools["videoPlaying"].Equals(true))
            {
                if (videoPlayer.isPlaying == false)
                {
                    if (stateHandler.GetComponent<StateHandler>().AllBools["rightVideoWatched"].Equals(false)) {
                        Debug.Log("Right video Ended, Spawning Arrow baby");
                        stateHandler.GetComponent<StateHandler>().AllBools["rightVideoWatched"] = true;
                    }
                }
            }
        }
    }

    private void ChangeVideoWhenTakingPills()
    {
        if (stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"].Equals(false))
        {
            distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

            // Bedingung 1 für Aufnehmen

            if (distance <= 1f)
            {
                hasPlayer = true;
            }
            else
            {
                hasPlayer = false;
            }

            if (hasPlayer)
            {
                if (Input.GetButtonDown("use"))
                {
                    videoPlayer.clip = videoHigh;
                    videoPlayer.Play();
                    Debug.Log("Target Texture changed");
                    stateHandler.GetComponent<StateHandler>().AllBools["pillsTaken"] = true;
                }
            }
        }
    }
}
