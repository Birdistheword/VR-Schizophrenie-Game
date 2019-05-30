using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour

{
    public GameObject cube;


    private bool scaleUpBool = false;
    private bool scaleDownBool = false;

    void Start()
    {
         scaleUpBool = false;
         scaleDownBool = false;
    }


    public void scaleUp()
    {

        scaleUpBool = true;     
        print("ScaleUp:" + scaleUpBool);
    }

    public void scaleDown()
    {

        scaleDownBool = true;
    }

    void Update(int x)
    {
        print("Update:" + scaleUpBool);
        if (x == 1 ) {
            cube.transform.localScale += new Vector3(1F, 1F, 1F) * Time.deltaTime;
        }
        else if (x == -1)
        {
            cube.transform.localScale += new Vector3(-1F, -1F, -1F) * Time.deltaTime;
        }
    }
      
}
