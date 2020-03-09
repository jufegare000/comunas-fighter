using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public Canvas CanvasObject;

    public void playGame()
    {
        //SceneManager.LoadScene("SampleScene");
        CanvasObject.enabled = false;
    }
    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
