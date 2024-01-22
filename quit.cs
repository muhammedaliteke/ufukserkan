using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene("anasahne");
    }
    public void QuitButton1()
    {
        Application.Quit();
    }

    public void seviye2Button()
    {
        SceneManager.LoadScene("2.sahne");
    }


}
