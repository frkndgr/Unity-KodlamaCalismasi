using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfFonksiyonu : MonoBehaviour
{
    [SerializeField]
    private int genislik = 1;

    [SerializeField]
    private float tekrarlamaMiktari = 0.1f;

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time*tekrarlamaMiktari)*genislik;

        float y = Mathf.Sin(Time.time*tekrarlamaMiktari)*genislik;

        float z = transform.position.z;

        transform.position = new Vector3(x,y,z);




    }
}
