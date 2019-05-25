using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedup : MonoBehaviour
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
        Vector3 v3 = new Vector3(10, 10, 10);
        v3 = Camera.main.transform.TransformDirection(v3);
        v3.z = 0;
        other.gameObject.GetComponent<Rigidbody>().AddForce(v3);
        print("speedup");
    }
}
