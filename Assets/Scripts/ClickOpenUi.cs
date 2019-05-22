using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOpenUi : MonoBehaviour
{
    // Gameobject das instanziert werden soll wird ausgewählt und die Position des Objects gemerkt
    [SerializeField] public GameObject myPrefab;
    private Vector3 posUp;
    private bool menuOpen = false;
    private GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        // Aktuelle Position + ein bisschen nach oben speichern
        posUp = transform.position;
        posUp.y += 2.0f;
      
        
        
    }


    void OnMouseDown()
    {
        // Instanzieren (was, wo, ?)
        if(menuOpen == false)
        {
            
            myPrefab = (GameObject) Instantiate(myPrefab, posUp, Quaternion.identity);
            menuOpen = true;
        }
        else if (menuOpen == true)
        {
            Destroy(myPrefab);
            menuOpen = false;
        }
       
    }
}
