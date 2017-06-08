using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour {

    public GameObject LProp1;
    public GameObject RProp1;
    public float IdleSpinRate;
    public float RunningSpinRate;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Vertical") == 0)
        {
            LProp1.transform.Rotate(0, 0, -IdleSpinRate);
            RProp1.transform.Rotate(0, 0, IdleSpinRate);
        }
        else
        {
            LProp1.transform.Rotate(0, 0, -RunningSpinRate);
            RProp1.transform.Rotate(0, 0, RunningSpinRate);
        }
	}
}
