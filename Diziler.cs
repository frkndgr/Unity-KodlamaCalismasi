using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiziManager : MonoBehaviour
{

    public string[] isimler;
    public string[] arabalar;
    public int[] yaslar;

    int rastgeleNo;

    void Start()
    {
        


    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Isimler : "+isimler[0]+ " Arabalar : "+arabalar[0]+" Yaslar : "+yaslar[0]);
        }
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            rastgeleNo = Random.Range(0, isimler.Length);

            Debug.Log("rastgele numara: " + rastgeleNo);

            Debug.Log("Isimler : "+isimler[rastgeleNo]+ " Arabalar : "+arabalar[rastgeleNo]+" Yaslar : "+yaslar[rastgeleNo]);
        }


    }
}
