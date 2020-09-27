using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiverwalkScript : MonoBehaviour
{
    public Text story;
    public GameObject badEndText;
    public GameObject tinaCry;
    public GameObject textBox;
    public GameObject tinaChar;
    public GameObject choices;

    void Start()
    {
        badEndText.SetActive(false);
        tinaCry.SetActive(false);

        if (GlobalVariables.stage == 4)
        {
            StartCoroutine(FirstDate());
        }
        else if (GlobalVariables.stage == 7)
        {
            StartCoroutine(SecondDate());
        }
        else if (GlobalVariables.stage == 10)
        {
            StartCoroutine(BadEnding3());
        }
    }

    void Update()
    {

    }
    IEnumerator FirstDate()
    {
        yield return new WaitForSeconds(5);
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
        GlobalVariables.choice = true;
    }

    IEnumerator SecondDate()
    {
        yield return new WaitForSeconds(5);
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
        GlobalVariables.choice = true;
    }

    IEnumerator BadEnding3()
    {
        choices.SetActive(false);

        story.text = "You decided that it wasn't a big deal, so you didn't apologize.";
        yield return new WaitForSeconds(5);

        story.text = "He truly didn't mind, but he forgot about you.";
        yield return new WaitForSeconds(5);

        textBox.SetActive(false);
        tinaChar.SetActive(false);

        badEndText.SetActive(true);
        tinaCry.SetActive(true);
    }
}