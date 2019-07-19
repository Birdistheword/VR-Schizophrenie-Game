using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowWhenApproached : MonoBehaviour
{
    private GameObject player;
    public Vector3 maxScale;
    private Vector3 minScale;
    public Vector3 grow;
    private float distance;

    public int DistanceToStartGrowing;



    void Start()
    {
        minScale = transform.localScale;
        player = GameObject.Find("Player");
        
    }

    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance <= DistanceToStartGrowing && distance != 0)
        {
            float scale = (1 / distance) * 5;
            grow = new Vector3(scale, grow.y, scale);
            if (grow.x < maxScale.x && grow.x >= minScale.x) transform.localScale = grow;
        }

    }

}