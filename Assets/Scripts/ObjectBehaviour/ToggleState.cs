using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleState : MonoBehaviour
{
    GameObject StateHandler;
    public Animation anim;
    [SerializeField] string triggerAnimationName;
    [SerializeField] string stateBoolName;

    void Start()
    {
        anim = GetComponent<Animation>();
        StateHandler = GameObject.Find("StateHandler");                
    }
    void Update()
    {
        if (!anim.IsPlaying(triggerAnimationName))
        {
            StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName] = true;
            Debug.Log(StateHandler.GetComponent<StateHandler>().AllBools[stateBoolName]);
        }
    }
}
