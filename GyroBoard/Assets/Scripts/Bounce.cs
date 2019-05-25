using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
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
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
        print("Bounce");
    }
}

