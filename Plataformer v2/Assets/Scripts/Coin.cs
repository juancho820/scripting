using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public GameObject coin;

    // Use this for initialization
    void Start () {

        coin.GetComponent<ParticleSystem>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            soundmanager.prendido = true;

            Instantiate(coin, transform.position, transform.rotation);

            scoremanager.addpoints(1);

            Destroy(gameObject);
            
        }
    }
}
