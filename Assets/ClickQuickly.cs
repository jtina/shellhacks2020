using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickQuickly : MonoBehaviour
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

            if (Input.GetKeyDown(KeyCode.Y))
            {
                GlobalVariables.stage = 4;
                SceneManager.LoadScene("SampleScene");
            }

            if (Input.GetKeyDown(KeyCode.N))
            {    
                GlobalVariables.stage = 5; //bad ending 2
                SceneManager.LoadScene("TinaBedroom Scene");
            }
        }


    }


}

