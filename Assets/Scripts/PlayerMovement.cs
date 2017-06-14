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
    private Vector3 movevec;
    private Vector3 turnvec;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        Level();
    }

    void Move()
    {
        vinput = Input.GetAxis("Vertical");
        hinput = Input.GetAxis("Horizontal");
        transform.rotation = new Quaternion(0,transform.rotation.y, 0, transform.rotation.w);
        movevec = new Vector3(hinput * body.velocity.magnitude / MaxSpeed * UpgradeNumber, Input.GetAxis("Lift") * 5, (vinput * PropForce + Mathf.Abs(hinput + body.angularVelocity.magnitude)) * UpgradeNumber);
        turnvec = new Vector3(0, (hinput * body.velocity.magnitude) / TurningForce, 0);
        body.AddRelativeForce(movevec);
        body.AddRelativeTorque(turnvec);
        if (body.position.y < 10)
            body.AddForce(0, 5, 0);
        else if (body.position.y > 160)
            body.AddForce(0, -5, 0);
    }

    void Level()
    {
        if(body.rotation.eulerAngles.x != 0)
        {
        }
    }

}