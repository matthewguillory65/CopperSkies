using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class CannonBallShoot : MonoBehaviour
{
    public GameObject CannonBallPrefab;
    public float force = 2500;
    public float timeTillShootAgain = 5;

    public void Start()
    {
        StartCoroutine(Shoot());
    }
    public void Update()
    {
        
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject cannonball = Instantiate(CannonBallPrefab, gameObject.transform);
                cannonball.GetComponent<Rigidbody>().AddRelativeForce(force, 0, 0);
                cannonball.transform.parent = null;
                yield return new WaitForSeconds(timeTillShootAgain);
            }
            yield return new WaitForSeconds(0.01f);
        }
    }

}