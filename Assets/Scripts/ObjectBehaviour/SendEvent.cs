using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{
    public GameObject player;
    public GameObject targetObject;
    private bool trigger;


    void Start()
    {
        
    }
    private void OnTriggerEnter (Collider col)
    {
        trigger = true;
        targetObject.SendMessage("messageReceiver", trigger);
        Debug.Log("EventSentEnter");
        
    }
    private void OnTriggerExit(Collider col)
    {
        trigger = false;
        targetObject.SendMessage("messageReceiver", trigger);
        Debug.Log("EventSentLeave");
    }

}
