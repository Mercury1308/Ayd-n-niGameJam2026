using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Book : MonoBehaviour
{

    /*
        public GameObject bookPanel;

        void OnMouseDown()
        {
            bookPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if(object ismi == book1)
        {
            bool book2 yi açabilir = true

        }

        if (object ismi == book2 ve book2 == true){
            book3 açabilir = true;
        }
    */



    public GameObject bookPanel;
    public GameObject hintPanel;
    public GameObject Portal;

    private Rigidbody2D rb_vase;

    public GameObject HintpanelTrigger;


    void Start()
    {
        GameObject target = GameObject.FindWithTag("Vase");
        rb_vase = target.GetComponent<Rigidbody2D>();
        rb_vase.simulated = false;


    }

    void OnMouseDown()
    {
        string bookName = gameObject.name;

        if (bookName == "Book1" && BookManager.book1Unlocked)
        {
            OpenBook();
            BookManager.book2Unlocked = true; // 2. kitap açıldı
            HintpanelTrigger.SetActive(true);
        }
        else if (bookName == "Book2" && BookManager.book2Unlocked)
        {
            OpenBook();
            BookManager.book3Unlocked = true; // 3. kitap açıldı
                                              //Rigidbody2D VaseRB = vase.GetComponent<Rigidbody2D>();
            Debug.Log("Book 2 yi açtın");
            rb_vase.simulated = true;

        }
        else if (bookName == "Book3(vase)" && BookManager.book3Unlocked)
        {
            //OpenBook();
            OpenBook();
            BookManager.book4Unlocked = true;

        }
        else if (bookName == "Book4" && BookManager.book4Unlocked)
        {
            /*
            OpenBook();
            BookManager.book5Unlocked = true;
            */
            Debug.Log("Buton 4 e tıkladın");
            Portal.SetActive(true);

        }
        else if (bookName == "Book5" && BookManager.book5Unlocked)
        {
            OpenBook();
        }

    }

    void OpenBook()
    {
        bookPanel.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && bookPanel.activeSelf)
        {
            bookPanel.SetActive(false);
            hintPanel.SetActive(true);
            Time.timeScale = 1;
            StartCoroutine(CloseHintAfterDelay(5f));
        }
    }

    private void loadParkourScene()
    {
        SceneManager.LoadScene("ParkourScene");
    }

    IEnumerator CloseHintAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // timeScale 0 olduğu için realtime kullanıyoruz
        hintPanel.SetActive(false);
        Time.timeScale = 1;
    }


}