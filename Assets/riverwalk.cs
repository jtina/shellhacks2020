using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class riverwalk : MonoBehaviour
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
            if (dist < 5.0f)
            {
                //if (Input.GetKeyDown(KeyCode.S))
                //{
                SceneManager.LoadScene("Riverwalk Scene");
                //}
                //GlobalVariables.level++;
                //Debug.Log(GlobalVariables.level);

            }
        }
    }


}
