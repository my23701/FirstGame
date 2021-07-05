﻿using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float forwardforce=2000f;
    public float sideforce=500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
