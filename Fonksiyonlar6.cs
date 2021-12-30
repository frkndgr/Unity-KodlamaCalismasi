using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar6 : MonoBehaviour
{
    public GameObject kupPrefab;

    private void Start()
    {
        Invoke("KupOlustur", 2f);
    }

    private void KupOlustur()
    {
        Instantiate(kupPrefab, transform.position, Quaternion.identity);
    }
}
