using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreenScript : View
{
    // Start is called before the first frame update
    [SerializeField] private Text lvlName;
    [SerializeField] private Text lvlDesc;
    void Start()
    {
        Cursor.visible = true;
        switch (SceneManager.GetActiveScene().name) {
            case "Level1":
                lvlName.text = "Maze";
                lvlDesc.text = "Find your way out of the maze.\n\n W - Move Forward\nS - Move Backward\nA - Move Left\nD - Move Right";
                break;
            case "Level2":
                lvlName.text = "Warehouse";
                lvlDesc.text = "The wonders you can do with a magic box.\n\n W - Move Forward\nS - Move Backward\nA - Move Left\nD - Move Right\nLeft Mouse Button - Grab Object";
                break;
            case "Level3":
                lvlName.text = "Tower";
                lvlDesc.text = "Can you get to the top and out?\n\n W - Move Forward\nS - Move Backward\nA - Move Left\nD - Move Right\nLeft Mouse Button - Grab Object";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
    }

    public void onContinuePressed() {
        ViewHandler.Instance.HideCurrentView();
    }
}
