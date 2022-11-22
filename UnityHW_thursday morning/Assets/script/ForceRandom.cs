using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceRandom : MonoBehaviour
{
    private float xforce = 1.0f;
    private float zforce = 1.0f;
    //private float Newxforce = 0;
    //private float Newzforce = 0;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(xforce, 0, zforce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        var Newforce = new Vector3(Random.Range(-2f, 2f), 0, Random.Range(-2f, 2f));
        rb.AddForce(Newforce, ForceMode.Impulse);

    }

}
