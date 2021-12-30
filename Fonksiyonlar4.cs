using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonksiyonManager : MonoBehaviour
{
    public Vector3[] pozisyonlar;

    private int rastgeleIndex;

    // Start is called before the first frame update
    void Start()
    {
        rastgeleIndex= RastgeleIndex();
        Debug.Log(rastgeleIndex);

        transform.position = KoordinatlariAl(rastgeleIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int RastgeleIndex()
    {
        return Random.Range(0, pozisyonlar.Length);
    }

    Vector3 KoordinatlariAl(int index)
    {
        return pozisyonlar[index];
    }
}
