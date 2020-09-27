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
        StartCoroutine(ExampleCoroutine());
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

        //change scene to TinaBedroom
        SceneManager.LoadScene("TinaBedroom Scene");
    }

}
