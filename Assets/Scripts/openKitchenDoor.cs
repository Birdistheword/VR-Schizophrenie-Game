using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openKitchenDoor : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("openKitchendoor");
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("closeKitchenDoor");
        }
    }
}
