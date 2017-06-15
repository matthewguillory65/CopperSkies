using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public Canvas PauseCanvas;
    
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseCanvas.enabled == false)
            PauseCanvas.enabled = true;
        if (Input.GetKeyDown(KeyCode.Escape) && PauseCanvas.enabled == true)
            PauseCanvas.enabled = false;
    }
}
