using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWhenInRange : MonoBehaviour
{
    public GameObject target;
    public Transform sameTarget;
    public float closestRangeToDrop;
     



    void Start()
    {
        GameObject player = GameObject.Find("Player");
        GameObject playercam = GameObject.Find("PlayerCam");
        Transform playercam2 = playercam.transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(gameObject.transform.position, sameTarget.position);
        if (distanceToTarget <= closestRangeToDrop)
        {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            Vector3 direction = (transform.position - sameTarget.transform.position).normalized;
            Debug.Log(direction);
            Ray ray = new Ray(direction, transform.position);
           
            
            GetComponent<Rigidbody>().AddForce(direction);
        }
    }
   

}

