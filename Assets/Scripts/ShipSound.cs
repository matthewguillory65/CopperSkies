using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSound : MonoBehaviour {

    public AudioSource SteamSound;
    public ParticleSystem Steam;

    private Rigidbody body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        SteamSound.pitch = 0.75f + body.velocity.magnitude / 15;
        SteamSound.volume = 0.5f + body.velocity.magnitude / 30;
        Steam.emissionRate = 40 + body.velocity.magnitude;
    }
}
