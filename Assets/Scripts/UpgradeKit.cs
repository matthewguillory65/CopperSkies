using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeKit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 10 * Time.deltaTime, 0);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<ShipHealth>().Heal();
            collision.gameObject.GetComponent<PlayerMovement>().UpgradeNumber++;
            collision.gameObject.GetComponent<PropellerController>().UpdateUpgrade();
            Destroy(gameObject);
        }
    }

}
