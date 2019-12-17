using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f,100f,0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }

    private void OnCollisionStay(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }

    private void OnCollisionExit(Collision col)
    {
        Debug.Log("Bounced off of" + col.gameObject.name);
    }

}
