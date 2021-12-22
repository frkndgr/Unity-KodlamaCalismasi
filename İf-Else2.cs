using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float quiz1,quiz2,quiz3,quiz4;

    float ortalama;




    // Start is called before the first frame update
    void Start()
    {
        quiz1=Random.Range(0,101);
        quiz2=Random.Range(0,101);
        quiz3=Random.Range(0,101);
        quiz4=Random.Range(0,101);

        ortalama=(quiz1+quiz2+quiz3+quiz4)/4;

        Debug.Log("Ortalama Deger"+ ortalama);

        if(ortalama>=90)
        {
            Debug.Log("ogrenci sinavdan AA almistir");
        } else if(ortalama>=80)

        {
            Debug.Log("ogrenci sinavdan BB almistir");
        } else if(ortalama>=70)
        {
            Debug.Log("ogrenci sinavdan CC almistir");
        } else
        {
            Debug.Log("ogrenci sinavdan kalmistir");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
