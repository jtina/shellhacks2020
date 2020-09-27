using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TinaBedroomScript : MonoBehaviour
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
        story.text = "Do I apologize the next time I see him?";
        //present choice boxes here
    }

}