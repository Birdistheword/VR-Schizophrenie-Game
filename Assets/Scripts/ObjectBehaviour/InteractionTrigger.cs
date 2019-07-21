using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public string[] boolToCheck, boolToSet;
    public GameObject[] targetObject;
    public AudioClip[] audioClip;
    GameObject player;
    GameObject StateHandler;
    float distanceToTarget = 100f;
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
         if(boolToCheck.Length > counter) distanceToTarget = Vector3.Distance(transform.position, targetObject[counter].transform.position);

        // Funktion ausführen, die State Handler prüft und updatet
        if (Input.GetButtonDown("use")) HandleState();
    }

    private void HandleState()
    {
        if (boolToCheck.Length > counter)
        {
            if (StateHandler.GetComponent<StateHandler>().AllBools[boolToCheck[counter]].Equals(true))
            {
                // State 0 success
                InteractionTriggerObject();

                if (success == true)
                {
                    Debug.Log("Length of boolToCheck Array: " + boolToCheck.Length);
                    Debug.Log("BoolToCheck:" + boolToCheck[counter] + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[boolToCheck[counter]]);
                    Debug.Log("BoolToSet:" + boolToSet[counter] + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[boolToSet[counter]]);
                    StateHandler.GetComponent<StateHandler>().AllBools[boolToSet[counter]] = true;
                    if (audioClip[counter]) GameObject.Find("AudioHandler").SendMessage("PlaySound", audioClip[counter]);
                    counter++;
                    success = false;
                    
                }

            }
        }
    }

    private void InteractionTriggerObject()
    {           
        if (distanceToTarget <= 7f)
        {
            Debug.Log("Distance to Target is smaller than 7f, success!");
            if (StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"].Equals(true))
            {
                Debug.Log("Object is in Hand, Transforming Object!");
                transform.localScale += new Vector3(0.2F, 0.2F, 0.2F);
                success = true;             
            }        
        }
    }
}
