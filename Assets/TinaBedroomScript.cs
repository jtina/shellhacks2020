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
            StartCoroutine(BadEnding());
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

    IEnumerator BadEnding()
    {
        choices.SetActive(false);

        if (GlobalVariables.stage == 3)
        {
            story.text = "I decided that it wasn't a big deal, so I didn't apologize.";
            yield return new WaitForSeconds(5);

            story.text = "He truly didn't mind, but he forgot about me.";
            yield return new WaitForSeconds(3);
        }

        else if (GlobalVariables.stage == 5)
        {
            story.text = "I didn't give him a chance and I chose to say no to going on a date with him";
            yield return new WaitForSeconds(3);
        }

        else if (GlobalVariables.stage == 10)
        {
            story.text = "I rejected him for a second time so he felt discouraged and we ended up breaking up.";
            yield return new WaitForSeconds(5);
        }

        else if (GlobalVariables.stage == 12)
        {
            story.text = "I didn't think that I was ready for a boyfriend, so I chose not to become his girlfriend";
            yield return new WaitForSeconds(5);
        }

        story.text = "Our story ends here";
        yield return new WaitForSeconds(3);

        textBox.SetActive(false);
        tinaChar.SetActive(false);

        badEndText.SetActive(true);
        tinaCry.SetActive(true);
    }
}