using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetsGame : MonoBehaviour
{
    public void LetsGamePlay()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("Butona bastın(Game sahnesi)");
    }
}
