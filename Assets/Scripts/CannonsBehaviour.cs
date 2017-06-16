using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CannonsBehaviour : NetworkBehaviour {

    public float LookSensitivity = 2;
    public float MaxX;
    public float MaxY;

    public Cannon L;
    public Cannon R;
    Cannon Selected;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isLocalPlayer)
        {
            if (Selected != null)
            {
                Selected.CannonLook(LookSensitivity);
                if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse0))
                {
                    L.Camera.SetActive(false);
                    R.Camera.SetActive(false);
                    Selected = null;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Selected = L;
                    L.Camera.SetActive(true);
                    R.Camera.SetActive(false);

                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    Selected = R;
                    R.Camera.SetActive(true);
                    L.Camera.SetActive(false);
                }
            }
        }

    }


}
