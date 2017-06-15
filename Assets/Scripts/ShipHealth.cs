using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour {

    public int Health = 100;
    public ParticleSystem DieParticles;
    public ParticleSystem HurtParticles;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Health <= 0)
            Die();
        HurtParticles.emissionRate = (100 - Health) / 10;

	}

    public void TakeDamage(int dam)
    {
        Health -= dam;
    }
    public void Heal()
    {
        Health = 100;
    }

    public void Die()
    {
        DieParticles.transform.parent = null;
        DieParticles.Play();
        Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (GetComponent<Rigidbody>().velocity.magnitude > 20 && other.gameObject.tag != "CannonBall")
            Health -= Mathf.RoundToInt(GetComponent<Rigidbody>().velocity.magnitude / 4);
    }
}
