using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathManager : MonoBehaviour
{
    public GameObject ball2;

    float hiz = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, ball2.transform.position, Time.deltaTime * hiz);
    }
}
