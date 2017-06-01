using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenus: MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas optionsCanvas;
    public Canvas controlsCanvas;


    public void CanvastoOptions()
    {
        mainCanvas.enabled = false;
        optionsCanvas.enabled = true;
    }

    public void CanvastoMain()
    {
        mainCanvas.enabled = true;
        optionsCanvas.enabled = false;
        controlsCanvas.enabled = false;
    }

    public void CanvastoControls()
    {
        mainCanvas.enabled = false;
        controlsCanvas.enabled = true;
    }

    public void PlayGame()
    {
        Application.LoadLevel("scene");
    }
}
