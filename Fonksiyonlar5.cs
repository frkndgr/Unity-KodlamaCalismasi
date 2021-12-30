using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar4 : MonoBehaviour
{
    public GameObject kup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            kup.SetActive(false);
            Destroy(kup,2f);
        }
    }
}
