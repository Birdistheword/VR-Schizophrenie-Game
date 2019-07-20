using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleState : MonoBehaviour
{
    GameObject StateHandler;
    private Animator anim;
    [SerializeField] string stateBoolName;

    void Start()
    {

        StateHandler = GameObject.Find("StateHandler");
        anim = gameObject.GetComponent<Animator>();
    }

    public void toggleState()
    {       
        StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName] = true;
        Debug.Log("Hallo Silviiii");
        Debug.Log(StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName]);
    }
    
}
