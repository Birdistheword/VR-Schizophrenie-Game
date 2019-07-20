using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public string boolToCheck;
    public string boolToSet;
    public GameObject targetObject;
    GameObject player;
    GameObject StateHandler;
    float distanceToTarget = 100f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        StateHandler = GameObject.Find("StateHandler");
    }

    void Update()
    {
        // Distanz zum gewünschten Objekt messen
         distanceToTarget = Vector3.Distance(gameObject.transform.position, targetObject.transform.position);

        // Funktion ausführen, die State Handler prüft und updatet
        if (Input.GetButtonDown("use")) InteractionTriggerObject();
    }

    private void InteractionTriggerObject()
    {           
        if (StateHandler.GetComponent<StateHandler>().AllBools[boolToCheck].Equals(true) && distanceToTarget <= 8f )
        {
            if (StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"].Equals(true))
            {
                StateHandler.GetComponent<StateHandler>().AllBools[boolToSet] = true;
                transform.localScale = new Vector3(2, 2, 2);
                Debug.Log("BoolToCheck:" + boolToCheck + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[boolToCheck]);
                Debug.Log("BoolToSet:" + boolToSet + " and value:" + StateHandler.GetComponent<StateHandler>().AllBools[boolToSet]);
            }        
        }
    }
}
