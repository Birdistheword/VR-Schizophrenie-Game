using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueTogetherWhenTouched : MonoBehaviour
{
    public GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        ContactPoint contact = col.contacts[0];
        Vector3 pos = contact.point;
        if (col.gameObject == target) Destroy(GetComponent<Rigidbody>());
    }

}