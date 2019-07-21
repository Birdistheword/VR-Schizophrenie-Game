using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{

    GameObject player;
    [SerializeField] AudioClip audioClip;



    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        
    }

   

    private void OnTriggerEnter (Collider col)
    {
        if (col == player) Debug.Log("Col ist player");
        GameObject.Find("AudioHandler").SendMessage("PlaySound", audioClip);
        
    }
    /*private void OnTriggerExit(Collider col)
    {
        trigger = false;
        targetObject.SendMessage("messageReceiver", trigger);
        Debug.Log("EventSentLeave");
    }*/
   

}
