using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
	public static int lifeCount = 3;
    public static bool died;
	
    // Start is called before the first frame update
    void Start()
    {
		died = false;
		
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            died = true;
        }
        if (died){
            lifeCount--;
            died = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
}
