using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructionScript : MonoBehaviour
{
    public GameObject destroyedVersion;
    GameObject stateHandler;
    public string stateToCheck;
    bool finished = false;

    private void Start()
    {
        stateHandler = GameObject.Find("StateHandler");
        Debug.Log(stateHandler);
    }
    private void Update()
    {
        if (finished == false) {
            if (stateHandler.GetComponent<StateHandler>().AllBools[stateToCheck].Equals(true))
            {
                GameObject glass = Instantiate(destroyedVersion, transform.position, transform.rotation);
                Destroy(gameObject);
                //glass.GetComponent<Rigidbody>().AddExplosionForce(2F, transform.position, 2F);
                finished = true;
            }
        }

    }
}
