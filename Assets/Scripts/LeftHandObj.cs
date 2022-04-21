using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandObj : MonoBehaviour
{
    public GameObject LeftHandReady;

    void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        LeftHandReady.SetActive(true);
    }
}
