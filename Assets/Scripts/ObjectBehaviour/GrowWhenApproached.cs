using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowWhenApproached : MonoBehaviour
{
    public Transform player;
    public Vector3 maxScale;
    private Vector3 minScale;
    private Vector3 grow;
    
    public int DistanceToStartGrowing;



    void Start()
    {
        minScale = transform.localScale;
    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);

        if (distance <= DistanceToStartGrowing && distance != 0)
        {
            float scale = (1 / distance) * 5;
            grow = new Vector3(scale, scale, scale);
            if (grow.x <= maxScale.x) transform.localScale = grow;
        }

    }

}