using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

    public bool pausegame;

	// Use this for initialization
	void Start () {

        pausegame = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onpause()
    {
        pausegame = !pausegame;
        if (!pausegame)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

    }
}
