using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveEventPosition : MonoBehaviour
{
    public GameObject thisObject;
    public Vector3 PositionBeiEnter;
    public Vector3 PositionBeiExit;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void messageReceiver(bool trigger)
    {

        if (trigger == true) thisObject.transform.position = PositionBeiEnter;
        else if (trigger == false) thisObject.transform.position = PositionBeiExit;

    }

}
