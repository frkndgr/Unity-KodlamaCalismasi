using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject kure;

    public int skor;


    // Start is called before the first frame update
    void Start()
    {
        kure.GetComponent<MeshRenderer>().material.color=Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && skor<=50)
        {
            skor+=25;
        }
        if(skor>50)
        {
            kure.GetComponent<MeshRenderer>().material.color=Color.blue;
        }
    }
}
