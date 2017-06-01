using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float PropForce = 10;
    public float MaxSpeed = 15;
    public float TurningForce = 10; //This is multiplied by the current speed

    private float CurrentSpeed;
    private Rigidbody body;
    private float vinput;
    private float hinput;
    private float dirRadian;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        vinput = Input.GetAxis("Vertical");
        hinput = Input.GetAxis("Horizontal");
        dirRadian = transform.rotation.eulerAngles.y / 180 * Mathf.PI;
        body.AddRelativeForce(Input.GetAxis("Horizontal") * body.velocity.magnitude / MaxSpeed, 0, (vinput * PropForce + Mathf.Abs(hinput * TurningForce / 2) ) );
        body.AddTorque(0, Input.GetAxis("Horizontal") * body.velocity.magnitude / MaxSpeed, 0);
        Vector3 SteeredVelocity = new Vector3(Mathf.Sin(dirRadian), 0, Mathf.Cos(dirRadian));
        //body.velocity = /*body.velocity +*/ SteeredVelocity * body.velocity.magnitude;
	}
}
