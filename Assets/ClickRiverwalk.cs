﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickRiverwalk : MonoBehaviour
{
    public GameObject yes_box;
    public GameObject no_box;

    public Text yes_choice;
    public Text no_choice;

    void Start()
    {
        yes_box.SetActive(false);
        yes_choice.enabled = false;
        no_box.SetActive(false);
        no_choice.enabled = false;
    }

    void Update()
    {
        if (GlobalVariables.choice == true)
        {
            yes_box.SetActive(true);
            yes_choice.enabled = true;
            no_box.SetActive(true);
            no_choice.enabled = true;

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null)
                {
                    if (hit.collider.gameObject.name == "Yes Box")
                    {
                        GlobalVariables.stage = 6;
                        SceneManager.LoadScene("SampleScene");
                    }

                    else if (hit.collider.gameObject.name == "No Box")
                    {
                        GlobalVariables.stage = 7; //bad ending 3
                        SceneManager.LoadScene("TinaBedroom Scene");

                    }
                }
            }
        }


    }


}