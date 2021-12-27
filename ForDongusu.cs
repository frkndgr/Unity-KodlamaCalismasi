using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string ad = "matematik";

    public int adet;




    void Start()
    {
        for(int i=0;i<10;i++)
        {
            Debug.Log(ad);
        }
        
        StartCoroutine(AdetArtirRoutine());

        
    }

    IEnumerator AdetArtirRoutine()
    {
        for(int i=0;i<100;i++)
        {
            adet++;

            yield return new WaitForSeconds(0.5f);
        }
    }

    
    void Update()
    {
        
    }
}
