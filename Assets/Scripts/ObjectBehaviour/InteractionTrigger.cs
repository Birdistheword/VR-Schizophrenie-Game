﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public string[] stateToCheck;
    public GameObject[] objectToCheck;
    public string[] stateToSet;
    public AudioClip[] audioClip;
    Animator animator;
    GameObject player;
    GameObject StateHandler;
    float distanceToTarget = 100f;
    float rangeToInteract = 2f;
    int counter = 0;
    bool success = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        StateHandler = GameObject.Find("StateHandler");
        
    }

    void Update()
    {
        // Distanz zum gewünschten Objekt messen
         if(objectToCheck.Length > counter) distanceToTarget = Vector3.Distance(transform.position, objectToCheck[counter].transform.position);

        // Funktion ausführen, die State Handler prüft und updatet
        if (Input.GetButtonDown("use")) HandleState();
    }

    private void HandleState()
    {
        if (stateToCheck.Length > counter)
        {
            if (StateHandler.GetComponent<StateHandler>().AllBools[stateToCheck[counter]].Equals(true))
            {
                // State[counter] success
                InteractionTriggerObject();

                if (success == true)
                {
                    Debug.Log("BoolToCheck:" + stateToCheck[counter] + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[stateToCheck[counter]]);
                    Debug.Log("BoolToSet:" + stateToSet[counter] + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[stateToSet[counter]]);
                   
                    StateHandler.GetComponent<StateHandler>().AllBools[stateToSet[counter]] = true;
                    if (audioClip.Length > counter) GameObject.Find("AudioHandler").SendMessage("PlaySound", audioClip[counter]);
                    counter++;
                    success = false;
                    
                }

            }
        }
    }

    private void InteractionTriggerObject()
    {           
        if (distanceToTarget <= rangeToInteract)
        {
            
            if (StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"].Equals(true))
            {
                Debug.Log("Object is in Hand, Transforming Object!");
                transform.localScale += new Vector3(0.2F, 0.2F, 0.2F);
                success = true;             
            }        
        }
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(objectToCheck[counter].transform.position, rangeToInteract);
    }

}
