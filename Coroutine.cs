using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public GameObject kup;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GorunurluguKapat());
    }

    IEnumerator GorunurluguKapat()
    {
        yield return new WaitForSeconds(3f);

        kup.SetActive(false);

        yield return new WaitForSeconds(2f);

        kup.SetActive(true);




    }
}
