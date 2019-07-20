using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 10;
    GameObject StateHandler;

    private Transform player;
    private Transform playerCam;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    



    void Start()
    {

        StateHandler = GameObject.Find("StateHandler");
        player = GameObject.Find("Player").transform;
        playerCam = GameObject.Find("PlayerCam").transform;

    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);
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
        GetComponent<Rigidbody>().isKinematic = true;
        transform.parent = playerCam;
        beingCarried = true;
        StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = true;
    }

    private void Carried()
    {
       /* if (touched)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            touched = false;
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;

        }
        else if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
        }
    }

    

    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }

}