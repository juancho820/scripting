using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldPerSec : MonoBehaviour {

    public Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        if (click.clickeado == true)
        {
            gpsDisplay.text = GetGoldPerSec() + click.goldperclick + " gold/sec" + "\n +gold/click";
        }
        else
        {
            gpsDisplay.text = GetGoldPerSec() + " gold/sec";
        }
    }

    public int GetGoldPerSec()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoGoldPerSec()
    {
        click.gold += GetGoldPerSec();
    }
    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(1);
        }
    }

}
