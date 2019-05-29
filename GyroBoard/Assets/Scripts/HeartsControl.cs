using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsControl : MonoBehaviour
{

    GameObject heart1;
    GameObject heart2;
    GameObject heart3;

    // Start is called before the first frame update
    void Start()
    {
        heart1 = GameObject.Find("Heart1");
        heart2 = GameObject.Find("Heart2");
        heart3 = GameObject.Find("Heart3");
        print(LifeController.lifeCount);
        switch (LifeController.lifeCount)
        {
            case 2:
                Destroy(heart3);
                break;
            case 1:
                Destroy(heart3);
                Destroy(heart2);
                break;
            case 0:
                GameObject.Find("GameOver").GetComponent<Text>().enabled = true;
                GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
