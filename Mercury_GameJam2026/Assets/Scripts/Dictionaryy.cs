using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaryy : MonoBehaviour
{
    public GameObject dictionaryPanel;

    void OnMouseDown()
    {
        dictionaryPanel.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && dictionaryPanel.activeSelf)
        {
            dictionaryPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
