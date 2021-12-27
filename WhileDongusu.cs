using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    


    void Start()
    {
        StartCoroutine(donguRoutine());
        
    }

    IEnumerator donguRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("her saniye bir ornek olussun");
        }
    }

    
    void Update()
    {
        
    }
}
