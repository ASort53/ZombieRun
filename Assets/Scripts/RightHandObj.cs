using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandObj : MonoBehaviour
{
    public GameObject RightHandReady;

    void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        RightHandReady.SetActive(true);
    }
}
