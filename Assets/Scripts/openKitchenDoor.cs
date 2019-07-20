using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openKitchenDoor : MonoBehaviour
{

    [SerializeField] Animator anim;
    [SerializeField] GameObject player;
    [SerializeField] float range = 3f;
    float distance = 100f;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }
    void OnTriggerEnter(Collider other)
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);


        if (Input.GetKeyDown("1") && distance < range)
        {
            anim.Play("openKitchendoor");
        }
        if (Input.GetKeyDown("2") && distance < range)
        {
            anim.Play("closeKitchenDoor");
        }
    }             
}

