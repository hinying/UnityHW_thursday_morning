using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            if (position.x > -9.5)
                position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            if (position.x < 9.5)
                position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            if (position.y < 9.5)
                position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            if (position.y > 1)
                position.y--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 position = this.transform.position;
            if (position.z < 9.5)
                position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Vector3 position = this.transform.position;
            if (position.z > -9.5)
                position.z--;
            this.transform.position = position;
        }
    }
}
