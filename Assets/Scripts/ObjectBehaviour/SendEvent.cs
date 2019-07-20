using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{
    public string boolToCheck;
    public string boolToSet;
    GameObject player;
    GameObject StateHandler;
    Animator anim;
    [SerializeField] string animationToBePlayed;
    public GameObject targetObject;
    bool trigger;
    float distanceToTarget;


    void Start()
    {
        player = GameObject.Find("Player");
        StateHandler = GameObject.Find("StateHandler");
        anim = targetObject.GetComponent<Animator>();

    }
    void Update()
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
