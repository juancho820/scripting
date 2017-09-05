using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    public Text goldDisplay;
    public Text gpc;
    public float gold = 0.00f;
    public int goldperclick = 1;
    public bool clickeado;
    public float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime;
        goldDisplay.text = "Gold: " + gold;
        gpc.text = goldperclick + " gold/click";
        if(tiempo>=1f)
        {
            clickeado = false;

        }
    }

    public void Clicked()
    {
        gold += goldperclick;
        clickeado = true;
        tiempo = 0;
    }

}
