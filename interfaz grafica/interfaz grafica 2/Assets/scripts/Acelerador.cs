using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Acelerador : MonoBehaviour
{

    public Click click;
    public bool activado = false;
    public float cooldown = 0;
    public bool CompCooldown = false;
    public bool unfill = true;
    public float tiempo = 0;
    public Scrollbar Bar;
    public float Fill = 10;


    void Update()
    {
        if (activado == true)
        {
            tiempo += Time.deltaTime;
            Fill -= Time.deltaTime;
            Bar.size = Fill/10f;
            if (tiempo >= 10)
            {
                CompCooldown = true;
                cooldown = 30;
                Fill = 0;
                click.goldperclick = click.goldperclick / 2;
                tiempo = 0;
                activado = false;
            }
            
        }
        if (CompCooldown == true)
        {
            cooldown -= Time.deltaTime;
            Fill += Time.deltaTime;
            Bar.size = Fill / 30f;
            if (cooldown <= 0)
            {
                unfill = true;
                cooldown = 0;
                CompCooldown = false;
            }
        }

    }
    public void AccUpgrade()
    {
        
        if(unfill == true)
        {        
            Fill = 10;
            activado = true;
            if (activado == true && cooldown == 0)
            {
                click.goldperclick = click.goldperclick * 2;
                unfill = false;
            }
        }
            
    }
}

