using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : MonoBehaviour
{

    [SerializeField] GameObject objectToSet;
    [SerializeField] string stateToCheck;
    GameObject stateHandler;
    bool toggle = false;
    // Start is called before the first frame update
    void Start()
    {

        stateHandler = GameObject.Find("StateHandler");
        Debug.Log("Setting Game Object to inactive");
        objectToSet.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == false)
        {
            if (stateHandler.GetComponent<StateHandler>().AllBools[stateToCheck].Equals(true))
            {
                objectToSet.SetActive(true);
               
                Debug.Log("Setting Game Object to active");
                toggle = true;
            }
        }
    }
}
