using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class items : MonoBehaviour {

    public static int llaves = 0;

    Text text;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {

        text.text = "Llaves:" + llaves;

    }
}
