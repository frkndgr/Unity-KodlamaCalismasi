using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonksiyonManager2 : MonoBehaviour
{
    public GameObject kup;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RengiDegistir(kup, Color.red);
        }
    }

    private void RengiDegistir(GameObject obje, Color istenenRenk)
    {
        obje.GetComponent<MeshRenderer>().material.color= istenenRenk;
    }
}
