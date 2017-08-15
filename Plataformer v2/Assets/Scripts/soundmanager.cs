using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour {

    private AudioSource audio;

    public static bool prendido = false;

	// Use this for initialization
	void Start () {

        

        audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        if (prendido)
        {
            audio.Play();
            prendido = false;
        }
        
		
	}
}
