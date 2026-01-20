using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ImageManager : MonoBehaviour
{
    [SerializeField] private Image questionImage;
    [SerializeField] private GameObject Maru_Image;
    [SerializeField] private GameObject Batsu_Image;

    [SerializeField] private Sprite[] spriteArray;
    [SerializeField] private string[] nameArray;

    int index;
    public int count;

    void Update()
    {
        if (count == 0)
        {
            index = Random.Range(0, spriteArray.Length);

            questionImage.color = new Color(0.0f, 0.0f, 0.0f);
            questionImage.sprite = spriteArray[index];
            count++;
        }
    }

    public void ChangeImage()
    {
        if (count == 5)
        {
            SceneManager.LoadScene("GameClear");
        }
        else
        {
            Maru_Image.SetActive(false);
            index = Random.Range(0, spriteArray.Length);

            questionImage.color = new Color(0.0f, 0.0f, 0.0f);
            questionImage.sprite = spriteArray[index];
        }
    }

    public void Button_1()
    {
        if (index == 0)
        {
            count++;
            questionImage.color = new Color(1.0f, 1.0f, 1.0f);
            Maru_Image.SetActive(true);
            Invoke("ChangeImage", 1.0f);
        }
        else
        {
            Batsu_Image.SetActive(true);
            Invoke("BatsuImage", 0.8f);
        }
    }

    public void Button_2()
    {
        if (index == 1)
        {
            count++;
            questionImage.color = new Color(1.0f, 1.0f, 1.0f);
            Maru_Image.SetActive(true);
            Invoke("ChangeImage", 1.0f);
        }
        else
        {
            Batsu_Image.SetActive(true);
            Invoke("BatsuImage", 0.8f);
        }
    }

    public void Button_3()
    {
        if (index == 2)
        {
            count++;
            questionImage.color = new Color(1.0f, 1.0f, 1.0f);
            Maru_Image.SetActive(true);
            Invoke("ChangeImage", 1.0f);
        }
        else
        {
            Batsu_Image.SetActive(true);
            Invoke("BatsuImage", 0.8f);
        }
    }

    public void Button_4()
    {
        if (index == 3)
        {
            count++;
            questionImage.color = new Color(1.0f, 1.0f, 1.0f);
            Maru_Image.SetActive(true);
            Invoke("ChangeImage", 1.0f);
        }
        else
        {
            Batsu_Image.SetActive(true);
            Invoke("BatsuImage", 0.8f);
        }
    }

    void BatsuImage()
    {
        Batsu_Image.SetActive(false);
    }
}
