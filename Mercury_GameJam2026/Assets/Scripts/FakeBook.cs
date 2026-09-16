using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeBook : MonoBehaviour
{
    public GameObject fakebookPanel;



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