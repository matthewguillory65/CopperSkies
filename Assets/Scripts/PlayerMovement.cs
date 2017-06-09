using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float PropForce = 10;
    public float MaxSpeed = 15;
    public float TurningForce = 10000; //This is multiplied by the current speed
    public int UpgradeNumber = 1;

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
        body.AddRelativeForce(Input.GetAxis("Horizontal") * body.velocity.magnitude / MaxSpeed * UpgradeNumber, Input.GetAxis("Lift") * 3, (vinput * PropForce + Mathf.Abs(hinput + body.angularVelocity.magnitude) ) * UpgradeNumber);
        body.AddRelativeTorque(0, (Input.GetAxis("Horizontal") * body.velocity.magnitude) / TurningForce, 0);
        if (body.position.y < 10)
            body.AddRelativeForce(0, 5, 0);
                
    }
}