﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetSurface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(rb.velocity * 2);
        print("Water");
    }
}
