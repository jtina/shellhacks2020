using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuicklyScript : MonoBehaviour
{
    public Text story;
    public GameObject jimChar;
    public GameObject tinaChar;
    public GameObject tinaWave;

    void Start()
    {
        jimChar.SetActive(false);
        tinaWave.SetActive(false);
        if (GlobalVariables.stage == 0)
        {
            StartCoroutine(BeginningScene());
        }
        else
        {
            StartCoroutine(Apology());
        }
    }

    void Update()
    {
        
    }
    IEnumerator BeginningScene()
    {
        yield return new WaitForSeconds(5);
        story.text = "The weekend was coming up and it was late, so I was in a rush to go home.";

        yield return new WaitForSeconds(5);
        story.text = "I didn't realize it at the time but " + 
            "this caused me to make a mistake and make the wrong drink for a very special customer.";

        yield return new WaitForSeconds(7);

        GlobalVariables.stage = 1;

        //change scene to SampleScene to get to bedroom
        //*******
        SceneManager.LoadScene("TinaBedroom Scene");
    }

    IEnumerator Apology()
    {
        GlobalVariables.choice = false;


        story.text = "I decided to apologize for messing up his drink.";
        yield return new WaitForSeconds(3);

        tinaChar.SetActive(false);
        tinaWave.SetActive(true);
        story.text = "\"Hi! I'm not sure if you remember but I accidentally made you the wrong drink last time.\"";
        yield return new WaitForSeconds(5);
        tinaWave.SetActive(false);

        jimChar.SetActive(true);
        story.text = "\"Oh haha, it's okay!\"";
        yield return new WaitForSeconds(3);
        story.text = "Oh wow, that was really cute. I wonder if I should ask for her name.";
        yield return new WaitForSeconds(5);


        jimChar.SetActive(false);

        story.text = "a few days pass...";
        yield return new WaitForSeconds(3);

        jimChar.SetActive(true);
        story.text = "\"Hey, can I take you out on a date some time?\"";
        yield return new WaitForSeconds(5);

        tinaChar.SetActive(true);
        story.text = "Should I say yes?";

        GlobalVariables.choice = true;
    }

}
