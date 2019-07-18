using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openFridge : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            anim.Play("openFridge");
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("closeFridge");
        }
    }
}
