using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JimBedroomScript : MonoBehaviour
{
    public Text story;
    public GameObject textBox;
    public GameObject tinaChar;
    public GameObject jimChar;
    public GameObject choices;
    void Start()
    {
        if (GlobalVariables.stage == 11)
        {
            StartCoroutine(SixMonths());
        }
        else if (GlobalVariables.stage == 13 || GlobalVariables.stage == 14)
        {
            StartCoroutine(Gifts());
        }
        else if (GlobalVariables.stage == 16)
        {
            StartCoroutine(NoHackathon());
        }

    }

    IEnumerator SixMonths()
    {
        GlobalVariables.choice = false;

        story.text = "We're approaching 6 months together";
        yield return new WaitForSeconds(3);

        story.text = "Should I get him a gift?";

        GlobalVariables.choice = true;
    }

    IEnumerator Gifts()
    {
        GlobalVariables.choice = false;

        if (GlobalVariables.stage == 13)
        {
            story.text = "Amazing! Both of us get a gift for one another";
            yield return new WaitForSeconds(3);
        }
        else
        {
            story.text = "I decide not to get a gift, but he surprises me with one! I feel bad for not getting a gift...";
            yield return new WaitForSeconds(5);
        }

        story.text = "Soon after, Jim invites me to participate in ShellHacks.";
        yield return new WaitForSeconds(5);

        story.text = "Should I join?";

        GlobalVariables.choice = true;
    }

    IEnumerator NoHackathon()
    {
        story.text = "Jim gets sad because ShellHacks is Awesome :(";
        yield return new WaitForSeconds(5);
    }


    
}