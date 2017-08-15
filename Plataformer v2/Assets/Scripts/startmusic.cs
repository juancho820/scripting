using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmusic : MonoBehaviour {

    private AudioSource audiojuego;

    public static bool prendidomusica = false;
    public static bool apagadomusica = false;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        audiojuego = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (prendidomusica)
        {
            prendermusica();
            prendidomusica = false;
        }
        if (apagadomusica)
        {
            apagarmusica();
            apagadomusica = false;
        }

    }

    public void prendermusica()
    {
        audiojuego.Play();
    }
    public void apagarmusica()
    {
        audiojuego.Stop();
    }
}
