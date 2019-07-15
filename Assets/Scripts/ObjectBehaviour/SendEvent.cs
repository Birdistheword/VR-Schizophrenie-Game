using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{
    public CharacterController player;
    public GameObject targetObject;
    private bool trigger;


    void Start()
    {
        
    }
    private void OnTriggerEnter (Collider col)
    {
        if (col == player) Debug.Log("Col ist player");
        trigger = true;
        targetObject.SendMessage("messageReceiver", trigger);
        Debug.Log(col);
        
    }
    private void OnTriggerExit(Collider col)
    {
        trigger = false;
        targetObject.SendMessage("messageReceiver", trigger);
        Debug.Log("EventSentLeave");
    }

}
