using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCannonBall : MonoBehaviour
{
    public int damage;

	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(TimeDelete());
	}

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.tag == "Player")
            other.gameObject.GetComponent<ShipHealth>().TakeDamage(damage);
    }

    IEnumerator TimeDelete()
    {
        yield return new WaitForSeconds(10);
    }
}
