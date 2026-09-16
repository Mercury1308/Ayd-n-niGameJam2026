using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public GameObject dictionaryPanel;
    void OnMouseDown()
    {
        dictionaryPanel.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            dictionaryPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
