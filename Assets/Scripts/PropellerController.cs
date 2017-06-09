using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour {

    public GameObject LProp1;
    public GameObject RProp1;
    public GameObject LProp2;
    public GameObject RProp2;
    public float RunningSpinRate;

    private Rigidbody body;

    private PlayerMovement shipstuff;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody>();
        shipstuff = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        LProp1.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) / 2);
        RProp1.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) / 2);
        LProp2.transform.Rotate(0, 0, (RunningSpinRate + body.velocity.magnitude) / 2);
        RProp2.transform.Rotate(0, 0, (-RunningSpinRate + -body.velocity.magnitude) / 2);
    }

    public void UpdateUpgrade()
    {
        switch(shipstuff.UpgradeNumber)
        {
            case 1:
                RProp2.SetActive(false);
                LProp2.SetActive(false);
                break;
            case 2:
                RProp2.SetActive(true);
                LProp2.SetActive(true);
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
