using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorOpen : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
             
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged")
        {
            _animator.SetBool("open", true);
        }
    }

    void Update()
    {
        
    }
}