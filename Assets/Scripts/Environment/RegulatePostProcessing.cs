using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class RegulatePostProcessing : MonoBehaviour
{
    PostProcessVolume postProcess;
    // Start is called before the first frame update
    void Start()
    {
        postProcess = GetComponent<PostProcessVolume>();

    }

    // Update is called once per frame
    void Update()
    {
        if(postProcess.weight <= 0.8) postProcess.weight = Time.time / 200;

    }
}
