using UnityEngine;
using System.Collections;

public class Spawncoins : MonoBehaviour {


    public Transform[] coinspawns;
    public GameObject coin;

    // Use this for initialization
    void Start () {

        Spawn();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn()
    {
        for (int i = 0; i< coinspawns.Length; i++)
        {
            int coinflip = Random.Range(0, 2);
            if (coinflip > 0)
            {
                Instantiate(coin, coinspawns[i].position, Quaternion.identity);
            }
        }
    }
}
