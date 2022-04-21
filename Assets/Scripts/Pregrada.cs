using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregrada : MonoBehaviour
{
    public GameObject RightHandReady;

    void OnTriggerEnter(Collider other)
    {
        RightHandReady.SetActive(false);
    }
}
