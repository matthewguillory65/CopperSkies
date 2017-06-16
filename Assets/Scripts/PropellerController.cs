using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour {

    public GameObject LProp1;
    public GameObject LProp2;
    public GameObject LProp2Obj;
    public GameObject RProp1;
    public GameObject RProp2;
    public GameObject RProp2Obj;
    public GameObject MProp1;
    public GameObject MProp1Obj;
    public GameObject MProp2;
    public GameObject MProp2Obj;
    public float RunningSpinRate;

    private Rigidbody body;

    private PlayerMovement shipstats;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody>();
        shipstats = GetComponent<PlayerMovement>();
	}

    // Update is called once per frame
    void Update()
    {
        RotateProps();
    }


    public void UpdateUpgrade()
    {
        switch(shipstats.UpgradeNumber)
        {
            case 1:

                break;
            case 2:
                LProp2Obj.SetActive(true);
                RProp2Obj.SetActive(true);
                break;
            case 3:
                MProp1Obj.SetActive(true);
                MProp2Obj.SetActive(true);
                break;
            default:
                break;
        }
    }

    void RotateProps()
    {
        switch (shipstats.UpgradeNumber) //Adjust rotations based on upgrade number
        {
            case 1:
                LProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                LProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                RProp1.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                RProp2.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                break;
            case 2:
                LProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                LProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                RProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                RProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                break;
            case 3:
                LProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                LProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                RProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                RProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                MProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) * Time.deltaTime * 30);
                MProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) * Time.deltaTime * 30);
                break;
            default:
                break;
        }
    }
}
