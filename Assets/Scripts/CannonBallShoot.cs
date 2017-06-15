using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallShoot : MonoBehaviour
{
    public GameObject CannonBallPrefab;
    public float speed = 20;
    public float timeTillShootAgain = 5;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cannonball = Instantiate(CannonBallPrefab, transform);
            cannonball.transform.parent = null;
            cannonball.GetComponent<Rigidbody>().AddRelativeForce(2700, 0, 0);
        }
    }
}
//yield return new WaitForSeconds(timeTillShootAgain);