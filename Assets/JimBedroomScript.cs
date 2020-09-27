using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JimBedroomScript : MonoBehaviour
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

        if (GlobalVariables.stage == 13)
        {
            StartCoroutine(SixMonths());
        }
        else if (GlobalVariables.stage == 15)
        {
            StartCoroutine(ShellHacks());
        }
        
    }

    void Update()
    {

    }
    IEnumerator SixMonths()
    {
        yield return new WaitForSeconds(5);
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
        GlobalVariables.choice = true;
    }

    IEnumerator ShellHacks()
    {
        yield return new WaitForSeconds(5);
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
        GlobalVariables.choice = true;
    }

    
}