using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOpenUi : MonoBehaviour
{
    [SerializeField] public GameObject myPrefab;
    private Vector3 posUp;

    // Start is called before the first frame update
    void Start()
    {
        posUp = transform.position;
        posUp.y += 2.0f;
      
        
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, posUp, Quaternion.identity);
    }
}
