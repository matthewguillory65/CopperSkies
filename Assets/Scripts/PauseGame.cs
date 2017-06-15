using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{

    public Canvas PauseCanvas;
    public Canvas OptionsCanvas;

    public void Start()
    {
        Debug.Log("Started");
    }
	
	// Update is called once per frame
	public void Update()
	{
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
            
            Debug.Log("Im working");
        }
	    if (PauseCanvas.enabled == true)
	    {
	        Time.timeScale = 0;
	    }
	    else
	    {
	        Time.timeScale = 1;
	    }
	}

    public void PauseToOptions()
    {
        PauseCanvas.enabled = false;
        OptionsCanvas.enabled = true;
    }

    public void OptionsToPause()
    {
        OptionsCanvas.enabled = false;
        PauseCanvas.enabled = true;
    }

    public void ResumeGame()
    {
        PauseCanvas.enabled = false;
    }

    public void ToMainMenu()
    {
        Application.LoadLevel("Scene.1_Menus");
    }

    public void Pause()
    {
        PauseCanvas.enabled = true;
    }
}
