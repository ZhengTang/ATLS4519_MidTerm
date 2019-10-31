using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransformCorrection : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject cameraProxy;
    public float lerpSpeed; // speed at which to interpolate between the proxy and main camera
    public Vector3 joystick = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            //parent.transform.position += (transform.right) * Input.GetAxis("Horizontal");
            joystick -= (transform.right) * Input.GetAxis("Horizontal");
        }
        else if (Input.GetAxis("Vertical") != 0)
        {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            //parent.transform.position += (transform.forward) * Input.GetAxis("Vertical");
            joystick -= (transform.forward) * Input.GetAxis("Vertical");
        }
        // Calculate the difference in rotation between the proxy rotation and current main camera rotation
        Quaternion correction = cameraProxy.transform.rotation * Quaternion.Inverse(mainCamera.transform.localRotation);
        // Set the rotation value of this camera to be a portion of the offset, over time this will correct slowly
        transform.rotation = Quaternion.Lerp(transform.rotation, correction, lerpSpeed);
        // copy the transform position
        transform.position = cameraProxy.transform.position + joystick;
    }
}
