using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleState : MonoBehaviour
{
    GameObject StateHandler;
    private Animator anim;
    [SerializeField] string boolToSet;

    void Start()
    {

        StateHandler = GameObject.Find("StateHandler");
        anim = gameObject.GetComponent<Animator>();
    }

    public void toggleState()
    {
        if (StateHandler.GetComponent<StateHandler>().AllBools.ContainsKey(boolToSet))
        {
            StateHandler.GetComponent<StateHandler>().AllBools[boolToSet] = true;
            Debug.Log("ToggleState - boolToSet: " + boolToSet + StateHandler.GetComponent<StateHandler>().AllBools[boolToSet]);
        }
        else Debug.Log("State " + boolToSet + " nicht gefunden! ERROR");
    }
    
}
