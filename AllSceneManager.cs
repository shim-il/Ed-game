using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AllSceneManager : MonoBehaviour
{
    public int scene = 1;
    public TextMeshProUGUI text_1;
    public TextMeshProUGUI text_2;
    public TextMeshProUGUI text_3;
    public TextMeshProUGUI text_4;
    public TextMeshProUGUI text_5;
    public TextMeshProUGUI text_6;
    public TextMeshProUGUI text_7;
    public TextMeshProUGUI text_8;
    public TextMeshProUGUI text_9;
    public TextMeshProUGUI text_10;
    public TextMeshProUGUI text_11;


    public void NextScene()
    {
        if (scene == 1 && text_2 != null)
        {
            scene = 2;
            text_1.gameObject.SetActive(false);
            text_2.gameObject.SetActive(true);
        }
        else if (scene == 2 && text_3 != null)
        {
            scene = 3;
            text_2.gameObject.SetActive(false);
            text_3.gameObject.SetActive(true);
        }
        else if (scene == 3 && text_4 != null)
        {
            scene = 4;
            text_3.gameObject.SetActive(false);
            text_4.gameObject.SetActive(true);
        }
        else if (scene == 4 && text_5 != null)
        {
            scene = 5;
            text_4.gameObject.SetActive(false);
            text_5.gameObject.SetActive(true);
        }
        else if (scene == 5 && text_6 != null)
        {
            scene = 6;
            text_5.gameObject.SetActive(false);
            text_6.gameObject.SetActive(true);
        }
        else if (scene == 6 && text_7 != null)
        {
            scene = 7;
            text_6.gameObject.SetActive(false);
            text_7.gameObject.SetActive(true);
        }
        else if (scene == 7 && text_8 != null)
        {
            scene = 8;
            text_7.gameObject.SetActive(false);
            text_8.gameObject.SetActive(true);
        }
        else if (scene == 8 && text_9 != null)
        {
            scene = 9;
            text_8.gameObject.SetActive(false);
            text_9.gameObject.SetActive(true);
        }
        else if (scene == 9 && text_10 != null)
        {
            scene = 10;
            text_9.gameObject.SetActive(false);
            text_10.gameObject.SetActive(true);
        }
        else if (scene == 10 && text_11 != null)
        {
            scene = 11;
            text_10.gameObject.SetActive(false);
            text_11.gameObject.SetActive(true);
        }
        else
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
        }
    }

    public void PrevScene()
    {
        if (scene == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
        }

        else if (scene == 2 && text_1 != null)
        {
            scene = 1;
            text_2.gameObject.SetActive(false);
            text_1.gameObject.SetActive(true);
        }
        else if (scene == 3 && text_2 != null)
        {
            scene = 2;
            text_3.gameObject.SetActive(false);
            text_2.gameObject.SetActive(true);
        }
        else if (scene == 4 && text_3 != null)
        {
            scene = 3;
            text_4.gameObject.SetActive(false);
            text_3.gameObject.SetActive(true);
        }
        else if (scene == 5 && text_4 != null)
        {
            scene = 4;
            text_5.gameObject.SetActive(false);
            text_4.gameObject.SetActive(true);
        }
        else if (scene == 6 && text_5 != null)
        {
            scene = 5;
            text_6.gameObject.SetActive(false);
            text_5.gameObject.SetActive(true);
        }
        else if (scene == 7 && text_6 != null)
        {
            scene = 6;
            text_7.gameObject.SetActive(false);
            text_6.gameObject.SetActive(true);
        }
        else if (scene == 8 && text_7 != null)
        {
            scene = 7;
            text_8.gameObject.SetActive(false);
            text_7.gameObject.SetActive(true);
        }
        else if (scene == 9 && text_8 != null)
        {
            scene = 8;
            text_9.gameObject.SetActive(false);
            text_8.gameObject.SetActive(true);
        }
        else if (scene == 10 && text_9 != null)
        {
            scene = 9;
            text_10.gameObject.SetActive(false);
            text_9.gameObject.SetActive(true);
        }
        else if (scene == 11 && text_10 != null)
        {
            scene = 10;
            text_11.gameObject.SetActive(false);
            text_10.gameObject.SetActive(true);
        }
    }
}
