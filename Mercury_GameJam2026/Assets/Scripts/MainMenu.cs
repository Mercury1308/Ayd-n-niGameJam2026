using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject fakebookPanel;


    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }


    void OpenFakeBook()
    {
        fakebookPanel.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && fakebookPanel.activeSelf)
        {
            fakebookPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void OnMouseDown()
    {
        OpenFakeBook();
    }
}