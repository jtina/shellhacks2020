﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GUIStyle guiStyle = new GUIStyle();


    void OnGUI()
    {
        guiStyle.fontSize = 25;
        GUI.Label(new Rect(10, 10, 300, 100), (string)GlobalVariables.states[GlobalVariables.level], guiStyle);
    }
}
