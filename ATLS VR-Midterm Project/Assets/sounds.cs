using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{

	public AudioSource drop;
    public AudioSource walk;
    public AudioSource pokpok;

    void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.name == "Planeb")
        {
            //Debug.Log("drop!!");
            drop.Play();
        }
    }

    private void Start()
    {
        pokpok.PlayDelayed(3);
    }
}
