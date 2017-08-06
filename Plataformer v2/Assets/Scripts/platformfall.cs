using UnityEngine;
using System.Collections;

public class platformfall : MonoBehaviour {

    public float fallDelay = 1f;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Awake ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            Invoke("fall", fallDelay);

    }

    void fall()
    {
        rb2d.isKinematic = false;
    }
}
