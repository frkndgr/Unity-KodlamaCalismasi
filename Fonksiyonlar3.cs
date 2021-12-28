using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar : MonoBehaviour
{
    public GameObject[] oyuncular;


    private void Start()
    {
        oyuncular = ButunOyunculariAl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] ButunOyunculariAl()
    {
        GameObject[] butunOyuncular = GameObject.FindGameObjectsWithTag("Player");

        foreach(var p in butunOyuncular)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return butunOyuncular;
    }
}
