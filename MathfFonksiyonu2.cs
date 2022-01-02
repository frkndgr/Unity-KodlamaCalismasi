using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfFonksiyonu2 : MonoBehaviour
{
    float minumum = -1.0f;
    float maximum = 1.0f;

    float t = 0.0f;

    
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(minumum, maximum, t), 0, 0);

        t += 0.5f * Time.deltaTime;

        if(t>1.0f)
        {
            float temp = maximum;
            maximum = minumum;
            minumum = temp;
            t = 0.0f;
        }
    }
}
