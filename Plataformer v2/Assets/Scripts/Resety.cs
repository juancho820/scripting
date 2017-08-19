using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resety : MonoBehaviour {

    public string lvltoload;

    // Update is called once per frame

    void Start()
    {
        startmusic.apagadomusica = true;
    }
    void Update()
    {

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
