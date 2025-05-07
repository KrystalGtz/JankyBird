using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;

    // Start is called before the first frame update
    // starts as soon as the script is enabled, runs once
    void Start()
    {
        
    }

    // Update is called once per frame
    // runs constantly while the script is enabled
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

    }
}
