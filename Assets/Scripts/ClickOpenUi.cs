using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOpenUi : MonoBehaviour
{
    // Gameobject das instanziert werden soll wird ausgewählt und die Position des Objects gemerkt
    [SerializeField] public GameObject myPrefab;
    private Vector3 posUp;
    private int menuOpen = 0;

    void Start()
    {
        // Aktuelle Position + ein bisschen nach oben speichern
        posUp = transform.position;
        posUp.y += 2.0f;
      
        
        
    }

    void OnMouseDown()
    {
        // Beim ERSTEN Click das Menü erstellen
        // Beim ZWEITEN Click das Menü DEactivaten
        // BEim DRITTEN CLick das Menü activaten
        if(menuOpen == 0)
        {
            
            myPrefab = (GameObject) Instantiate(myPrefab, posUp ,Quaternion.identity);
            menuOpen = 1;
        }
        else if (menuOpen == 1)
        {
            myPrefab.transform.gameObject.SetActive(false);
            menuOpen = 2;
        }
        else if (menuOpen == 2)
        {
            myPrefab.transform.gameObject.SetActive(true);
            menuOpen = 1;

        }

    }
}
