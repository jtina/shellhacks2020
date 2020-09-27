using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RiverwalkScript : MonoBehaviour
{
    public Text story;

    public GameObject textBox;
    public GameObject tinaChar;
    public GameObject jimChar;
    public GameObject tinaShy;
    public GameObject jimShy;
    public GameObject choices;

    public Text yes;
    public Text no;

    void Start()
    {
        jimShy.SetActive(false);
        tinaShy.SetActive(false);

        if (GlobalVariables.stage == 4) //say yes to the date
        {
            StartCoroutine(FirstDate());
        }
        else if (GlobalVariables.stage == 7)
        {
            StartCoroutine(SecondDate());
        }
        else if (GlobalVariables.stage == 9 || GlobalVariables.stage == 6)
        {
            StartCoroutine(Girlfriend());
        }
    }
    IEnumerator FirstDate()
    {
        GlobalVariables.choice = false;
        tinaChar.SetActive(false);
        jimChar.SetActive(false);

        tinaShy.SetActive(true);
        jimShy.SetActive(true);
        story.text = "We went on a few dates together and I think that I really like him.";
        yield return new WaitForSeconds(5);
        story.text = "For one of our dates, we ended up going to Tampa Riverwalk.";
        yield return new WaitForSeconds(5);

        jimShy.SetActive(false);
        story.text = "He leans in for a kiss, should I kiss him back?";

        GlobalVariables.choice = true;
    }

    IEnumerator SecondDate()
    {
        GlobalVariables.choice = false;

        story.text = "I decided not to kiss him just yet because I didn't feel ready just yet.";
        yield return new WaitForSeconds(5);

        story.text = "We go on another date at Riverwalk after a few weeks.";
        yield return new WaitForSeconds(3);

        jimChar.SetActive(false);
        story.text = "He leans in for another kiss, what should I do?";

        yes.text = "kiss him";
        no.text = "reject him";

        GlobalVariables.choice = true;
    }

    IEnumerator Girlfriend()
    {
        GlobalVariables.choice = false;


        story.text = "We kissed and soon after, he asked me to be his girlfriend";
        yield return new WaitForSeconds(5);

        story.text = "Should I become his girlfriend?";

        GlobalVariables.choice = true;
    }
}