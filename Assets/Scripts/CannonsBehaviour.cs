using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonsBehaviour : MonoBehaviour {

    public GameObject CannonBaseL;
    public GameObject CannonMainL;
    public GameObject CannonBaseR;
    public GameObject CannonMainR;
    public float LookSensitivity;
    public float MaxX;
    public float MaxY;

    Cannon L;
    Cannon R;
    Cannon Selected;
    class Cannon
    {
        public GameObject Base;
        public GameObject Main;

        public Cannon(GameObject B, GameObject M)
        {
            Base = B;
            Main = M;
        }
    }

	// Use this for initialization
	void Start ()
    {
        L = new Cannon(CannonBaseL, CannonMainL);
        R = new Cannon(CannonBaseR, CannonMainR);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Selected = L;
        if (Input.GetKeyDown(KeyCode.Mouse1))
            Selected = R;

        if (Selected != null)
        {
            CannonLook();
            if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse0))
                Selected = null;
        }
    }

    void CannonLook()
    {
        Selected.Base.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        Selected.Main.transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0);
    }
}
