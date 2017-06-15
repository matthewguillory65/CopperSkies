using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCannonBall : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
