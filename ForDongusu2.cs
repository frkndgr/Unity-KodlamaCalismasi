using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject kure;

    private int renkKodu;


    void Start()
    {
        kure.GetComponent<MeshRenderer>().material.color=Color.blue;

        StartCoroutine(AdetArtirRoutine());
    }
    IEnumerator AdetArtirRoutine()
    {
        for(int i=0;i<100;i++)
        {
            renkKodu++;

            yield return new WaitForSeconds(1);

            if(renkKodu==4)
            {
                renkKodu= 0;
            }
        }

        
    }

    
    void Update()
    {
        

        switch(renkKodu)
        {
            case 1:
                kure.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
                
            case 2:
                kure.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            
            case 3:
                kure.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            
            case 4:
                kure.GetComponent<MeshRenderer>().material.color = Color.green;
                break;        
        }
    }
}
