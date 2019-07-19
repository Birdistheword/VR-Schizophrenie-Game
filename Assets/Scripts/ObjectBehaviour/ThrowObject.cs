using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{
    public GameObject target;
    public float throwForce = 10;
    public float closestRangeToDrop;

    private Transform player;
    private Transform playerCam;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    



    void Start()
    {
        

        player = GameObject.Find("Player").transform;
        playerCam = GameObject.Find("PlayerCam").transform;

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

        if (hasPlayer && Input.GetButtonDown("use")) PickUp();

        if (beingCarried) Carried();
    }

    private void PickUp()
    {
        var otherGameObjects = FindObjectsOfType<ThrowObject>();
        GetComponent<Rigidbody>().isKinematic = true;
        transform.parent = playerCam;
        beingCarried = true;
        for (int i = 0; i <= otherGameObjects.Length; ++i)
        {
            Debug.Log(otherGameObjects[i]);
        }
    }

    private void Carried()
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
            transform.parent = target.transform;
            transform.position = col.transform.position;
            
            
        }
    }

}