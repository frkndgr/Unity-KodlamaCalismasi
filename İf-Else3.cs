using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegiskenManager : MonoBehaviour
{
    
    int kolaySeviye=0;
    int ortaSeviye=1;
    int zorSeviye=2;
    
    int gecerliSeviye;


    // Start is called before the first frame update
    void Start()
    {
        gecerliSeviye=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(gecerliSeviye==kolaySeviye)
        {
            Debug.Log("gecerli seviyeniz kolay seviye");
        } else if(gecerliSeviye==ortaSeviye)
        {
            Debug.Log("gecerli seviyeniz orta seviye");
        } else
        {
            Debug.Log("su anki seviyeniz zor seviye");
        }
        
    }
}
