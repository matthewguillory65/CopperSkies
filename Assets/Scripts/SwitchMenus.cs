using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenus: MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas optionsCanvas;
    public Canvas controlsCanvas;
    public Canvas pauseCanvas;
    public Canvas pause_OptionCanvas;


    public void CanvastoOptions()
    {
        mainCanvas.enabled = false;
        optionsCanvas.enabled = true;
    }

    public void PausetoOptions()
    {
        pauseCanvas.enabled = false;
        pause_OptionCanvas.enabled = true;
    }

    public void OptionstoPause()
    {
        pause_OptionCanvas.enabled = false;
        pauseCanvas.enabled = true;
    }

    public void PausetoGame()
    {
        pauseCanvas.enabled = false;
    }

    public void OptionstoMain()
    {
        mainCanvas.enabled = true;
        optionsCanvas.enabled = false;
    }

    public void ControlstoMain()
    {
        mainCanvas.enabled = true;
        controlsCanvas.enabled = false;
    }

    public void CanvastoControls()
    {
        mainCanvas.enabled = false;
        controlsCanvas.enabled = true;
    }

    public void PauseMenutoMainMenu()
    {
        //Application.LoadLevel("MainMenu");
        mainCanvas.enabled = true;
        pauseCanvas.enabled = false;
    }

    public void PlayGame()
    {
        //Application.LoadLevel("ActualGame");
        mainCanvas.enabled = false;
    }
}
