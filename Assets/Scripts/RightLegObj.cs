using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLegObj : MonoBehaviour
{
    public GameObject RightLegReady;

    void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        RightLegReady.SetActive(true);
    }
}
