using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 10;
    GameObject StateHandler;


    private Transform player;
    private Transform playerCam;
    bool hasPlayer = false;
    
    private bool touched = false;



    [HideInInspector] public bool beingCarried = false;
    [HideInInspector] public enum State { onGround, inHand };
    [HideInInspector] public State state = State.onGround;



    void Start()
    {

        StateHandler = GameObject.Find("StateHandler");
        player = GameObject.Find("Player").transform;
        playerCam = Camera.main.transform;

    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);

        // Bedingung 1 für Aufnehmen

        if (distance <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        // Bedingung 2 und 3 für aufnehmen
        if (hasPlayer && Input.GetButtonDown("use")) PickUp();

        if (GetComponent<dartBehaviour>() != null && state == State.inHand)
            GetComponent<dartBehaviour>().DropWhenInRange();


        if (state == State.inHand) Carried();
    }

    private void PickUp()
    {
        // Falls schon was in der Hand ist kein Pickup!
        if (StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"].Equals(true)) return;
        GetComponent<Rigidbody>().isKinematic = true;
        transform.parent = playerCam;
        transform.localPosition = new Vector3(0F, 0F, 2.2F);
        StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = true;
        state = State.inHand;
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
            GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
            state = State.onGround;

        }
        else if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            StateHandler.GetComponent<StateHandler>().AllBools["objectInHand"] = false;
            state = State.onGround;
        }
    }

    

    /*void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }*/

}