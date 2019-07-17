using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDart : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    public GameObject target;
    public Transform sameTarget;
    public float closestRangeToDrop;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    private bool repel = true;


    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);
        float distanceToTarget = Vector3.Distance(gameObject.transform.position, sameTarget.position);
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
        if (distanceToTarget <= closestRangeToDrop && repel == true)
        {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            Vector3 direction = (transform.position - sameTarget.transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(direction * 2);
            beingCarried = false;
        }
        if (distanceToTarget >= closestRangeToDrop && repel == false) repel = true;

        if (beingCarried)
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
            ContactPoint contact = col.contacts[0];
            Vector3 pos = contact.point;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = sameTarget;
            repel = false;
        }
    }

}
/*float distanceToTarget = Vector3.Distance(gameObject.transform.position, sameTarget.position);
        if (distanceToTarget <= closestRangeToDrop)
        {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            Vector3 direction = (transform.position - sameTarget.transform.position).normalized;
            Debug.Log(direction);
            Ray ray = new Ray(direction, transform.position);


            GetComponent<Rigidbody>().AddForce(direction);
        }
*/
