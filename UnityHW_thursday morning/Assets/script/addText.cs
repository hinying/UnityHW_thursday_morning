using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        textMeshPro.SetText("try");
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;
        string time = currentTime.ToString("HH:mm:ss");
        textMeshPro.SetText(time);
    }
}