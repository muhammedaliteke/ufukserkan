using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class arabago : MonoBehaviour
{
    bool finish = false;
   public  int puan = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        puan = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().AddForce(-4, 0, 0, ForceMode.Force);
        }
            if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 3, ForceMode.Force);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -3, ForceMode.Force);
              }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "engel") 
        {
            Invoke("restart", 1f);
            finish = true;
        }
        if (collision.collider.tag == "coin")
        {
            puan++;
            Destroy(collision.gameObject);
         
        }
        if(collision.collider.tag == "f")
        {
                Invoke("restart", 1f);
               finish = true;

        }
    }

    private void restart()
    {
        SceneManager.LoadScene("quit");
        finish = false;
    }




}
