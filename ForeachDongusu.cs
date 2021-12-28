using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiziManager2 : MonoBehaviour
{
    public string[] dersler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //for(int i=0;i<dersler.Length;i++)
            //{
            //    Debug.Log(dersler[i]);
            //}
        
            foreach (var ders in dersler)
            {
                Debug.Log(ders);
            }
        
        
        }





    }
}
