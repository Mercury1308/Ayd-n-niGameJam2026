using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book1UI : MonoBehaviour
{

    public GameObject bookPanel;

    public void OpenBook()
    {
        bookPanel.SetActive(true);
        Time.timeScale = 0f; // oyun durur
    }

    public void CloseBook()
    {
        bookPanel.SetActive(false);
        Time.timeScale = 1f; // oyun devam eder
    }


}
