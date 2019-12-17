using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(new Vector3(0, 6.5f, 0), ForceMode.Impulse);
        }
    }
}
