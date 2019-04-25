using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //If a gameObject with the tag "Player" enters this trigger, load a scene.
        if (other.gameObject.tag == "Player")
        {
            if(scene.name == "FlatSurface")
                Application.LoadLevel("SlopedPath");
            else if (scene.name == "SlopedPath")
                Application.LoadLevel("End");
        }
    }
}
