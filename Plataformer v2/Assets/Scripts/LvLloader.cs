using UnityEngine;
using System.Collections;

public class LvLloader : MonoBehaviour {

    public string lvltoload;
    public AudioSource musicainicio;

    // Use this for initialization
    void Start (){

        musicainicio = GetComponent<AudioSource>();
        musicainicio.Play();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            OnMouseUp();
        }

    }

    private void OnMouseUp()
    {
        Application.LoadLevel(lvltoload);
    }
}
