using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce : MonoBehaviour
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
        Vector3 movement = new Vector3(100, 0, 100);
        Vector3 v3 = transform.TransformDirection(movement);
        other.gameObject.GetComponent<Rigidbody>().AddForce(v3);
        print("Bounce");
    }

}
