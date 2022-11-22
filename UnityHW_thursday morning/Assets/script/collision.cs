using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using TMPro;

public class collision : MonoBehaviour
{
    private int Score1;
    public GameObject myobj3, myobj4;
    public TextMesh textMesh3;
    public TextMeshPro textMeshPro4;
    // Start is called before the first frame update
    void Start()
    {
        Score1 = 0;
        if (GameObject.Find("looseScore"))
        {
            myobj3 = GameObject.Find("looseScore");
            textMesh3 = myobj3.GetComponent<TextMesh>();
            textMesh3.text = "0";
        }
        if (GameObject.Find("endText"))
        {
            myobj4 = GameObject.Find("endText");
            textMeshPro4 = myobj4.GetComponent<TextMeshPro>();
            //textMeshPro4.text = "game start";
        }
    }

    // Update is called once per frame
    void Update()
    {
    }



    /**
    private void OnCollisionEnter(Collision collision)
    {
        Score1++;
        textMesh3.text = Score1.ToString();
        

    }
    **/
    private void OnTriggerEnter(Collider other)
    {
        Score1++;
        textMesh3.text = Score1.ToString();
        if (Score1 == 4)
        {
            textMeshPro4.text = "You are Loose!";

        }
    }
}