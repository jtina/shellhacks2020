using System.Collections;
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
        
           
                    if (GlobalVariables.stage == 4) 
                    {
                        if (Input.GetKeyDown(KeyCode.Y))
                        {
                            GlobalVariables.stage = 6;
                            SceneManager.LoadScene("Riverwalk Scene");
                        }
                        if (Input.GetKeyDown(KeyCode.N))
                        {
                            GlobalVariables.stage = 7;
                            SceneManager.LoadScene("Riverwalk Scene");
                        }
                    }
                    else if (GlobalVariables.stage == 7) //no to kiss, second chance
                    {
                        if (Input.GetKeyDown(KeyCode.Y))
                        {
                            GlobalVariables.stage = 9;
                            SceneManager.LoadScene("Riverwalk Scene");
                        }
                        if (Input.GetKeyDown(KeyCode.N))
                        {
                            GlobalVariables.stage = 10;
                            SceneManager.LoadScene("TinaBedroom Scene");
                        }
                    }
                    else if (GlobalVariables.stage == 6 || GlobalVariables.stage == 9) //
                    {
                        if (Input.GetKeyDown(KeyCode.Y))
                        {
                            GlobalVariables.stage = 11;
                            SceneManager.LoadScene("SampleScene");
                        }
                        if (Input.GetKeyDown(KeyCode.N))
                        {
                            GlobalVariables.stage = 12;
                            SceneManager.LoadScene("TinaBedroom Scene");
                        }
                    }
                }
            }
        }