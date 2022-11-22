using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCameraKeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)
          || Input.GetKeyDown(KeyCode.S)
          || Input.GetKeyDown(KeyCode.A)
          || Input.GetKeyDown(KeyCode.D))
            Camera.main.transform.Translate(Input.GetAxisRaw("Horizontal") * 2, Input.GetAxisRaw("Vertical") * 2, 0);

    }

}