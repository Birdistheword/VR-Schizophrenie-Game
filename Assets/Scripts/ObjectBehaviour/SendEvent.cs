using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{
    public string stateBoolName;
    GameObject player;
    GameObject StateHandler;
    public Animator anim;
    [SerializeField] string animationName;
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
        // Distanz zum gewünschten Objekt messen
        distanceToTarget = Vector3.Distance(gameObject.transform.position, targetObject.transform.position);

        // Funktion ausführen, die State Handler prüft und updatet
        InteractionTriggerObject();
    }

    private void InteractionTriggerObject()
    {
        if (Input.GetButtonDown("use") && distanceToTarget <= 3f)
        {
            if (StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName].Equals(true))
            {
                anim.Play(animationName);
                Debug.Log("Contains Key:" + stateBoolName + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName]);
            }
        }
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
