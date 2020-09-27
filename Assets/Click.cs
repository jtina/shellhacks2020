using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    private bool clicking = false;
    
    
    void Update()
    {
        if(clicking == true)
        {
            SceneManager.LoadScene("Quickly Scene");
        }
    }

    private void ChoiceClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            clicking = true;
        }
    }
}
