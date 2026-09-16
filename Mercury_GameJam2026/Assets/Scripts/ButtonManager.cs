using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject hintPanel;
    public GameObject book1Panel;
    public GameObject book2Panel;
    public GameObject book3Panel;
    public GameObject book4Panel;
    public GameObject book5Panel;

    private bool canOpen2;


    void Start()
    {

    }


    public void OpenHint()
    {
        hintPanel.SetActive(true);
        Time.timeScale = 0;
        StartCoroutine(CloseHintAfterDelay(5f));
    }

    public void CloseHint()
    {
        hintPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CloseBook1()
    {
        book1Panel.SetActive(false);
        Time.timeScale = 1;
    }


    public void CloseBook2()
    {
        book2Panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CloseBook3()
    {
        book3Panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CloseBook4()
    {
        book4Panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CloseBook5()
    {
        book5Panel.SetActive(false);
        Time.timeScale = 1;
    }

    IEnumerator CloseHintAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // timeScale 0 olduğu için realtime kullanıyoruz
        hintPanel.SetActive(false);
        Time.timeScale = 1;
    }



}
