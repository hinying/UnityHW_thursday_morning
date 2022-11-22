using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        textMeshPro.text = "time";
        //extMeshPro.SetText("time table");
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime timenow = System.DateTime.Now;
        string timeString = timenow.ToString("HH:mm:ss");
        textMeshPro.text = timeString;
    }
}