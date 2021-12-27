using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int kolayseviye=0;
    int ortaseviye=1;
    int zorseviye=2;

    int secilenseviye;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(secilenseviye==kolayseviye)
        {
            Debug.Log("kolay seviye");
        } else if (secilenseviye==ortaseviye)
        {
            Debug.Log("orta seviye");
        } else if(secilenseviye==zorseviye)
        {
            Debug.Log("zor seviye");
        } else
        {
            Debug.Log("herhangi bir seviye secmediniz");
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            secilenseviye= Random.Range(0,3);
        }*/

        switch(secilenseviye)
        {
            case 0:
                Debug.Log("kolay seviye");
            break;

            case 1:
                Debug.Log("orta seviye");
                break;

            case 2:
                Debug.Log("zor seviye");
                break;
            
            default:
                Debug.Log("herhangi bir seviye secmediniz");
                break;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            secilenseviye= Random.Range(0,3);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            secilenseviye= 55;
        }
    }
    

}
