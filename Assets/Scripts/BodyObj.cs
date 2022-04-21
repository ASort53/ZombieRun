using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyObj : MonoBehaviour
{
    public GameObject BodyReady;

    void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        BodyReady.SetActive(true);
    }
}
