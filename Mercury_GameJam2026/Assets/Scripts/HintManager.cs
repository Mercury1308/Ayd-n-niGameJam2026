using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintManager : MonoBehaviour
{

    public GameObject hintPanel;
    public GameObject hintText1;
    public GameObject hintText2;
    public GameObject hintText3;

    public GameObject hintText4;
    //public GameObject hintText5;

    private bool open;

    void Start()
    {
        if (open == false)
        {
            hintText1.SetActive(true);
            hintText2.SetActive(false);
            hintText3.SetActive(false);
            StartCoroutine(CloseHintAfterDelay(5f));
        }

        //hintText4.SetActive(false);
        //hintText5.SetActive(false);  }

    }



    void Update()
    {
        /*
        if (BookManager.book1Unlocked == true)
        {
            hintText1.SetActive(true);
            hintText2.SetActive(false);
            hintText3.SetActive(false);

            //hintText4.SetActive(false);
            //hintText5.SetActive(false);
        }
        */

        if (BookManager.book2Unlocked == true)
        {
            hintText1.SetActive(false);
            hintText2.SetActive(true);
            hintText3.SetActive(false);
            //hintText4.SetActive(false);
            //hintText5.SetActive(false);
        }
        if (BookManager.book3Unlocked == true)
        {
            hintText1.SetActive(false);
            hintText2.SetActive(false);
            hintText3.SetActive(true);

            //hintText4.SetActive(false);
            //hintText5.SetActive(false);
        }


        if (BookManager.book4Unlocked == true)
        {
            hintText1.SetActive(false);
            hintText2.SetActive(false);
            hintText3.SetActive(false);
            hintText4.SetActive(true);
            //hintText5.SetActive(false);
            open = true;

        }

    }


    IEnumerator CloseHintAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // timeScale 0 olduğu için realtime kullanıyoruz
        hintPanel.SetActive(false);
        Time.timeScale = 1;
    }









}
