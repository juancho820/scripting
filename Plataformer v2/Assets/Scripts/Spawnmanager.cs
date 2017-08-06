using UnityEngine;
using System.Collections;

public class Spawnmanager : MonoBehaviour {

    public int maxplatforms = 20;
    public GameObject platform;
    public float horizontalmin = 6.5f;
    public float horizontalmax = 14f;
    public float verticalmin = 6f;
    public float verticalmax = 6f;

    private Vector2 originposition;


	// Use this for initialization
	void Start ()
    {
        originposition = transform.position;

        spawn();

	}
	
    void spawn()
    {
        for (int i = 0; i < maxplatforms; i++)
        {
            Vector2 randposition = originposition + new Vector2 (Random.Range(horizontalmin, horizontalmax), Random.Range(verticalmin,verticalmax));
            Instantiate(platform, randposition, Quaternion.identity);
            originposition = randposition;
        }
    }
}
