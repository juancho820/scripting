﻿using UnityEngine;
using System.Collections;

public class LvLloader : MonoBehaviour {

    public string lvltoload;

    // Use this for initialization
    void Start (){

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            OnMouseUp();
        }

    }

    private void OnMouseUp()
    {
        Application.LoadLevel(lvltoload);
    }
}
