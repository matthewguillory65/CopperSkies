using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour {

    public GameObject LProp1;
    public GameObject RProp1;
    public float RunningSpinRate;

    private Rigidbody body;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
            LProp1.transform.Rotate(0, 0, -RunningSpinRate + -body.velocity.magnitude);
            RProp1.transform.Rotate(0, 0, RunningSpinRate + body.velocity.magnitude);
	}
}
