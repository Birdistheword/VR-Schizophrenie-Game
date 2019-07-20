using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveEventToggle : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] string animationName="";
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void messageReceiver()
    {
        anim.Play(animationName);
    }
}
