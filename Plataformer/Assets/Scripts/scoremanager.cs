using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {

    public static int score = 0;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        
    }

    void Update()
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;
        
    }

    public static void addpoints (int pointstoadd)
    {
        score += pointstoadd; 
    }

    public static void reset()
    {
        score = 0;
    }
}
