using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint1Trigger : MonoBehaviour
{

    public GameObject hint1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MainCharacter")
        {
            hint1.SetActive(true);
            Debug.Log("Kod çalıştı");
        }
    }
}
