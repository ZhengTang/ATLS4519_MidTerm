using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{

	public AudioSource drop;
    public AudioSource walk;

    void OnTriggerEnter()
    {
        drop.Play();
    }

    private void Start()
    {
        walk.PlayDelayed(2);
    }
}
