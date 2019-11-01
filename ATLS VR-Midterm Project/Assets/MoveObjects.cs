using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public Transform guide;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = guide.transform.position;
            this.transform.rotation = guide.transform.rotation;
            this.transform.parent = GameObject.Find("guide").transform;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.transform.parent = null;
        }
    }
}
