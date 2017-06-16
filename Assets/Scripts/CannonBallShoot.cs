using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CannonBallShoot : NetworkBehaviour
{
    public Transform ShootPosition;
    public GameObject CannonBallPrefab;
    public float force = 2500;
    public float timeTillShootAgain = 5;
    public GameObject camera;
    public AudioSource Sound;

    bool CanFire = true;
    public Rigidbody ship;

    public void Start()
    {
            
    }
    public void Update()
    {
        if(isLocalPlayer)
            if (Input.GetKey(KeyCode.Space) && camera.activeSelf && CanFire)
            {
                CmdShoot();
                StartCoroutine(ShootCooldown());
            }
    }

    [Command]
    void CmdShoot()
    {
        Sound.Play();
        GameObject cannonball = Instantiate(CannonBallPrefab, ShootPosition);
        cannonball.transform.parent = null;
        NetworkServer.Spawn(cannonball);
        cannonball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(force, 0, 0));
    }

    IEnumerator ShootCooldown()
    {
        CanFire = false;
        yield return new WaitForSeconds(timeTillShootAgain);
        CanFire = true;
    }
}