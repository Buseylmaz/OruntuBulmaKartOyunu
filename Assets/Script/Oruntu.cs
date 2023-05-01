using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Oruntu : MonoBehaviour
{

    int sayı1 = 0;
    int sayı2 = 0;
    int sayı3 = 0;
    int sayı4 = 0;
    int sayı5 = 0;

    
    public Button cevap1;
    public Button cevap2;
    public Button cevap3;
    public Button cevap4;
    public Button cevap5;

    public Image img;
    public Text text;

    void Start()
    {

        StartCoroutine(Resim());
        
    }

    void Update()
    {
        
        Soru1();
        Soru2();
        Soru3();
        Soru4();
        Soru5();
    }


    public void Soru1()
    {  if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            sayı1 += 1;
            cevap1.transform.Find("Text").GetComponent<Text>().text = "" + sayı1;
        }

        else if (sayı1>= 1 && Input.GetKeyDown(KeyCode.A))
        {
            sayı1 -= 1;
            cevap1.transform.Find("Text").GetComponent<Text>().text = "" + sayı1;
        }
    }

    public void Soru2()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            sayı2 += 1;
            cevap2.transform.Find("Text").GetComponent<Text>().text = "" + sayı2;
        }
        else if (sayı2 >= 1 && Input.GetKeyDown(KeyCode.B))
        {
            sayı2 -= 1;
            cevap2.transform.Find("Text").GetComponent<Text>().text = "" + sayı2;
        }
    }

    public void Soru3()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            sayı3 += 1;
            cevap3.transform.Find("Text").GetComponent<Text>().text = "" + sayı3;
        }
        else if (sayı3 >= 1 && Input.GetKeyDown(KeyCode.C))
        {
            sayı3 -= 1;
            cevap3.transform.Find("Text").GetComponent<Text>().text = "" + sayı3;
        }
    }
    public void Soru4()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            sayı4 += 1;
            cevap4.transform.Find("Text").GetComponent<Text>().text = "" + sayı4;
        }
        else if (sayı4 >= 1 && Input.GetKeyDown(KeyCode.D))
        {
            sayı4 -= 1;
            cevap4.transform.Find("Text").GetComponent<Text>().text = "" + sayı4;
        }
    }
    public void Soru5()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            sayı5 += 1;
            cevap5.transform.Find("Text").GetComponent<Text>().text = "" + sayı5;
        }
        else if (sayı5 >= 1 && Input.GetKeyDown(KeyCode.E))
        {
            sayı5 -= 1;
            cevap5.transform.Find("Text").GetComponent<Text>().text = "" + sayı5;
        }
    }

    public void Gecis(int sahneid)
    {
        SceneManager.LoadScene(1);
    }

    public void Cıkıs(int sahneid)
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator Resim()
    {
        img.enabled = true;
        text.enabled = true;
        yield return new WaitForSeconds(20);
        img.enabled = false;
        text.enabled = false;
    }


}
