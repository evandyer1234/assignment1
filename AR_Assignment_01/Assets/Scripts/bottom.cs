using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom : MonoBehaviour
{
    public GameObject text;
    
    void OnTriggerEnter(Collider collision)
    {
        text.SetActive(true);
        Time.timeScale = 0f;
    }
}
