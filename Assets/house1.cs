using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class house1 : MonoBehaviour
{
    public Transform fpp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fpp)
        {
            float dist = Vector3.Distance(fpp.position, transform.position);
            if(dist < 10.0f)
            {
                //if (Input.GetKeyDown(KeyCode.S))
                //{
                   SceneManager.LoadScene("rpgpp_lt_scene_1.0");
                //}
                //GlobalVariables.level++;
                //Debug.Log(GlobalVariables.level);
              
            }
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
    }
}
