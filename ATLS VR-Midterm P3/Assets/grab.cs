using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public Transform guide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ////Debug.Log(other.name);
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Debug.Log("holding");
        //    //other.GetComponent<Rigidbody>().useGravity = false;
        //    //other.GetComponent<Rigidbody>().isKinematic = true;
        //    //other.transform.position = guide.transform.position;
        //    //other.transform.rotation = guide.transform.rotation;
        //    //other.transform.parent = GameObject.Find("guide").transform;
        //}

        //if (Input.GetButtonUp("Fire1"))
        //{
        //    Debug.Log("released");
        //    //other.GetComponent<Rigidbody>().useGravity = true;
        //    //other.GetComponent<Rigidbody>().isKinematic = false;
        //    //other.transform.parent = null;
        //}
    }

    public void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.name);
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("holding");
            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.position = guide.transform.position;
            other.transform.rotation = guide.transform.rotation;
            other.transform.parent = GameObject.Find("guide").transform;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            Debug.Log("released");
            other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<Rigidbody>().isKinematic = false;
            other.transform.parent = null;
        }
    }
}
