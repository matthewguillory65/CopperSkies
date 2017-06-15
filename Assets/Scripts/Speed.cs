using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public float currentSpeed;
    float maxSpeed = 15.0f;
    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    text.text = currentSpeed.ToString();
	}
}
