using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonksiyonManager : MonoBehaviour
{
    public int saglikDurumu;


    public void Hasar(int hasarMiktari)
    {
        saglikDurumu -= hasarMiktari;

        if(saglikDurumu<1)
        {
            saglikDurumu = 0;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Hasar(5);
        }
    }
}
