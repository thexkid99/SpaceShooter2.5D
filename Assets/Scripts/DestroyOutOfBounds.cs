using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 5;
    private float lowerBound = -5;
    public GameObject spaceShip;

    void Start()
    {
        spaceShip = GameObject.Find("Player");
    }
    
    void Update()
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);           
        }
        else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
