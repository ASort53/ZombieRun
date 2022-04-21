using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void PauseLevel()
    {
        Time.timeScale = 0;
    }
}
