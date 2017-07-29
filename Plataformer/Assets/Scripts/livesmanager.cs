using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class livesmanager : MonoBehaviour {

    public static int lifes = 3;
    public static string lvltoload;

    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        //lifes = 3;

    }
	
	// Update is called once per frame
	void Update () {

        text.text = "" + lifes;


        if (lifes <= 0)
        {
            Application.LoadLevel("Game Over");
            lifes = 3;
            scoremanager.score = 0;
        }

    }

    public static void lostlifes(int lifestolose)
    {
        lifes -= lifestolose;
    }

}
