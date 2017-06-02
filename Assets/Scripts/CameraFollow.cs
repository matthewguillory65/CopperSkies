using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float Distance;
    public float Height;
    public Rigidbody ObjectToFollow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 BehindPos = new Vector3(Mathf.Sin(ObjectToFollow.rotation.eulerAngles.y / 180 * Mathf.PI) * Distance + ObjectToFollow.position.x, Height + ObjectToFollow.position.y, Mathf.Cos(ObjectToFollow.rotation.eulerAngles.y / 180 * Mathf.PI) * Distance + ObjectToFollow.position.z);
        GetComponent<Rigidbody>().velocity = (BehindPos - GetComponent<Rigidbody>().position) * 2;
        transform.LookAt(new Vector3(ObjectToFollow.position.x, ObjectToFollow.position.y + Height, ObjectToFollow.position.z));
        //GetComponent<Rigidbody>().angularVelocity = ObjectToFollow.rotation.eulerAngles / 180 * Mathf.PI - GetComponent<Rigidbody>().rotation.eulerAngles / 180 * Mathf.PI;
    }
}