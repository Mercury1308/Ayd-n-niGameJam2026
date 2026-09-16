using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("InformationScene");
        Debug.Log("Butona bastın(Information)");
    }
}
