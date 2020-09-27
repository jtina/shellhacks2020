using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TinaBedroomScript : MonoBehaviour
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

        if (GlobalVariables.stage == 1)
        {
            StartCoroutine(FirstChoice());
        }
        else
        {
            StartCoroutine(BadEnding1());
        }
    }

    void Update()
    {
        
    }
    IEnumerator FirstChoice()
    {
        yield return new WaitForSeconds(5);
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
        GlobalVariables.choice = true;
    }

    IEnumerator BadEnding1()
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