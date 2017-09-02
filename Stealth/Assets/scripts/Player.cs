using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public event System.Action OnReachedEndOfLevel;

    public float moveSpeed = 7;
    public float smoothMoveTime = .1f;
    public float turnSpeed = 8;

    public static bool congActivado;

    float angle;
    float smoothInputMagnitude;
    float smoothMoveVelocity;
    Vector3 velocity;

    new Rigidbody rigidbody;
    bool disabled;

	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody>();
        Guard.OnGuardHasSpottedPlayer += Disable;
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 inputDirection = Vector3.zero;
        if (!disabled)
        {
            inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        }
        float inputMagnitude = inputDirection.magnitude;
        smoothInputMagnitude = Mathf.SmoothDamp(smoothInputMagnitude, inputMagnitude, ref smoothMoveVelocity, smoothMoveTime);

        float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
        angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * turnSpeed *inputMagnitude);

        velocity = transform.forward * moveSpeed * smoothInputMagnitude;

        if (Input.GetKeyDown("space"))
        {
            if (congActivado == false)
            {
                congelar();
            }
            else
            {
                Debug.Log("Esta en cooldown");
            }
        }
    }

    void OnTriggerEnter(Collider hitCollider)
    {
            if (hitCollider.tag == "Finish" && ScoreManager.Instance.CurrentScore == 3)
            {
                Disable();
                if (OnReachedEndOfLevel != null)
                {
                    OnReachedEndOfLevel();
                }
            }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Disable();
        }
        if(collision.gameObject.tag == "llave")
        {
            ScoreManager.Instance.IncreaseScore();
        }
    }

    public void Disable()
    {
        disabled = true;
    }

    void FixedUpdate()
    {
        rigidbody.MoveRotation(Quaternion.Euler(Vector3.up * angle));
        rigidbody.MovePosition(rigidbody.position + velocity * Time.deltaTime);
       
    }

    void OnDestroy()
    {
        Guard.OnGuardHasSpottedPlayer -= Disable;
    }

    public void congelar()
    {
        congActivado = true;
        Cooldown.tiempodeCooldown = 5;
        Cooldown.activado = true;
        Guard.pararguardias = true;
    }
}
