using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLegObj : MonoBehaviour
{
    public GameObject LeftLegReady;

    void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        LeftLegReady.SetActive(true);
    }
}
