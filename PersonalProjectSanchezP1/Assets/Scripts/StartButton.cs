using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public Button button;
    private GameManager gameManager;
    void Start()
    {
        //Calling the button functions
        button = GetComponent<Button>();
        //Onbutton click the function StartOnClick will be called 
        button.onClick.AddListener(StartOnClick);
        //finding GameManager to start game
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void StartOnClick()
    {
        Debug.Log("Start button was clicked");
        gameManager.StartGame();

    }
    public void MoveToScene(int SceneID)
    {
        //when the fuction is called through the button press the scene manager 
        //will load scene 1
    SceneManager.LoadScene(SceneID);
    }
}
