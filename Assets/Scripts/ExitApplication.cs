﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("I'm working");
    }
}
