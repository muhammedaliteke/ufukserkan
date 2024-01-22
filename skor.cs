using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Text score;
    public arabago arabago;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = arabago.puan.ToString();
    }
}
