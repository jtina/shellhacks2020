using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuicklyScript : MonoBehaviour
{
    public Text story;

    void Start()
    {
        if (GlobalVariables.stage == 0)
        {
            StartCoroutine(ExampleCoroutine());
        }
        else
        {
            StartCoroutine(ExampleCoroutine2());
        }
    }

    void Update()
    {
        
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
        story.text = "The weekend was coming up and it was late, so I was in a rush to go home.";

        yield return new WaitForSeconds(5);
        story.text = "I didn't realize it at the time but " + 
            "this caused me to make a mistake and make the wrong drink for a very special customer.";

        yield return new WaitForSeconds(7);

        GlobalVariables.stage = 1;

        //change scene to TinaBedroom
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator ExampleCoroutine2()
    {
        GlobalVariables.choice = false;

        

        yield return new WaitForSeconds(7);
    }

}
