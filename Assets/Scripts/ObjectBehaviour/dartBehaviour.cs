using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(ThrowObject))]
public class dartBehaviour : MonoBehaviour
{
    [SerializeField] float closestRangeToDrop = 5f;
    [SerializeField] GameObject target;
    GameObject StateHandler;
    bool repel = true;

    float distanceToTarget;

    
    // Start is called before the first frame update
    void Start()
    {
        StateHandler = GameObject.Find("StateHandler");
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(transform.position, target.transform.position);
    }

    public void DropWhenInRange()
    {
        if (distanceToTarget <= closestRangeToDrop && repel == true)
        {
            Debug.Log("DropWhenInRange()");
            
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            Vector3 direction = (transform.position - target.transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(direction * 2);
            GetComponent<ThrowObject>().state = ThrowObject.State.onGround;
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
        }
        else if (distanceToTarget >= closestRangeToDrop && repel == false) repel = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == target)
        {
            ContactPoint contact = col.contacts[0];
            Vector3 pos = contact.point;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(transform.parent, true);
            repel = false;
            GetComponent<ThrowObject>().state = ThrowObject.State.onGround;
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
        }
    }
}
