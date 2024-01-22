using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class giris : MonoBehaviour
{
 public void PlayButton()
    {
        SceneManager.LoadScene("2.sahne");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void storeButton()
    {
        SceneManager.LoadScene("store");
    }
   
    

}
