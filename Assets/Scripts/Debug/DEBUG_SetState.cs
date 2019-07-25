using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG_SetState : MonoBehaviour
{
    [SerializeField] string boolToSet;
    GameObject stateHandler;
    // Start is called before the first frame update
    void Start()
    {
        stateHandler = GameObject.Find("StateHandler");
        stateHandler.GetComponent<StateHandler>().AllBools[boolToSet] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
