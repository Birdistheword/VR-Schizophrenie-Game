using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationIfStateIsTrue : MonoBehaviour
{
    Animator animator;
    GameObject stateHandler;
    public string stateToCheck;
    public string animationName;
    bool toggle = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        stateHandler = GameObject.Find("StateHandler");


    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == false)
        {
            if ( stateHandler.GetComponent<StateHandler>().AllBools[stateToCheck].Equals(true))
            {
                Debug.Log("State is true");
                animator.Play(animationName);
                toggle = true;
            }
        }
    }
}
