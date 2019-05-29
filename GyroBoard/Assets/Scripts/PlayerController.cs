using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using System;


public class PlayerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
    
    private Text debugText;


    // At the start of the game..
    void Start ()
	{
		rb = GetComponent<Rigidbody>();

        //debugText = GameObject.Find("DebugText").GetComponent<Text>();

        
    }



    void FixedUpdate ()
	{
#if UNITY_EDITOR
       // debugText.text = "unityEditor";
        float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        movement = Camera.main.transform.TransformDirection(movement);

#else
        Vector3 movement = BTCntrl.ReadAxisFromBTDevice();
        NormelizeMovment(ref movement);
#endif

        movement.y = 0;
        Vector3 force = movement.normalized * speed;

        

        for (int i = 0; i < 3; i++)
        {
            if (rb.velocity[i] > 10)
            {
                movement[i] = 0;
            }
            else if(rb.velocity[i] < -10)
            {
                movement[i] = 0;
            }
        }

        rb.AddForce(movement * speed);
        print(rb.velocity.ToString());
	}



    void NormelizeMovment(ref Vector3 vec)
    {
       // debugText.text = vec.ToString();
        Vector3 center = new Vector3(0, 750 ,-1500);
        vec -= center;

        for(int i = 0; i < 3; i++)
        {
            if( Math.Abs(vec[i]) < 750)
            {
                vec[i] = 0;
            }
        }

        vec.x = Remap(vec.y, -5000, 5000, -1, 1);
        vec.z = Remap(vec.z, -5000, 5000, -1, 1);
        vec.y = 0;
        //debugText.text += " | " + vec.ToString();
    }

    public static float Remap(float value, float fromSource, float toSource, float fromTarget, float toTarget)
    {
        if(value < fromSource)
        {
            value = fromSource;
        }
        else if (value > toSource)
        {
            value = toSource;
        }
        return value / toSource;
    }
}
