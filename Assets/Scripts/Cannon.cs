using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject Base;
    public GameObject Main;
    public GameObject Camera;
    public int invertOrNot;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void CannonLook(float sense)
    {
        Base.transform.Rotate(0, Input.GetAxis("Mouse X") * sense, 0);
        Main.transform.Rotate(0, 0, -Input.GetAxis("Mouse Y") * sense * invertOrNot);
    }
}
