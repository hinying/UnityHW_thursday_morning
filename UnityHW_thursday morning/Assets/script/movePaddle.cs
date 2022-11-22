using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class movePaddle : MonoBehaviour
{
    public GameObject myObj1, myObj2, myObj5;
    public TextMesh textMesh1, textMesh2;
    public int Score2;
    public TextMeshPro textMeshPro5;
    // Start is called before the first frame update
    void Start()
    {
        Score2 = 0;
        if (GameObject.Find("winScore"))
        {
            myObj1 = GameObject.Find("winScore");
            textMesh1 = myObj1.GetComponent<TextMesh>();
            textMesh1.text = Score2.ToString();
        }
        /**
        if (GameObject.Find("looseScore"))
        {
            myObj2 = GameObject.Find("looseScore");
            textMesh2 = myObj2.GetComponent<TextMesh>();
            textMesh2.text = "0 score";
        }
        **/
        if (GameObject.Find("endText"))
        {
            myObj5 = GameObject.Find("endText");
            textMeshPro5 = myObj5.GetComponent<TextMeshPro>();
            //textMeshPro4.text = "game start";
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 2)
            {
                transform.Translate(0f, 0.1f, 0f);//up
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1.7)
            {
                transform.Translate(0f, -0.1f, 0f);//down
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 4.5)
            {
                transform.Translate(0.1f, 0f, 0f);//right
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4.5)
            {
                transform.Translate(-0.1f, 0f, 0f);//left
            }

        }
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Score2++;
        textMesh1.text = Score2.ToString();
        if (Score2 == 10)
        {
            textMeshPro5.text = "You are Win!";
            Time.timeScale = 0;//0°±¤î, 1Ä~Äò
        }
    }
}

