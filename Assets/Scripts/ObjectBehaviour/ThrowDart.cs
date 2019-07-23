using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDart : MonoBehaviour
{
    /*public float throwForce = 10;

    public GameObject target;
    public float closestRangeToDrop;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    private bool repel = true;


    Transform player;
    Transform playerCam;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        playerCam = GameObject.Find("PlayerCam").transform;
        dartBehaviour = GetComponent<dartBehaviour>();
    }
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);
        float distanceToTarget = Vector3.Distance(gameObject.transform.position, target.transform.position);
        if (distance <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;

        }
            DropWhenInRange(distanceToTarget);

        if (beingCarried) CarryHandler();
    }

    private void CarryHandler()
    {      
        if (touched)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            touched = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);

        }
        else if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;            
        }
    }

    private void DropWhenInRange(float distanceToTarget)
    {
        if (distanceToTarget <= closestRangeToDrop && repel == true)
        {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            Vector3 direction = (transform.position - target.transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(direction * 2);
            beingCarried = false;
        }
        else if (distanceToTarget >= closestRangeToDrop && repel == false) repel = true;
    }

    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == target)
        {
            var originalScale = transform.localScale;
            ContactPoint contact = col.contacts[0];
            Vector3 pos = contact.point;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = target.transform;
            transform.localScale = originalScale;
            repel = false;
        }
    }
    */
}

