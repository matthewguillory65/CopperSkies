using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalCameraSet : NetworkBehaviour {

    public override void OnStartLocalPlayer()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().ObjectToFollow = GetComponent<Rigidbody>();
    }

}
