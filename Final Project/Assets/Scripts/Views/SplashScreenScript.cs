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
                lvlName.text = "Level2";
                lvlDesc.text = "LevelDesc";
                break;
            case "Level3":
                lvlName.text = "Level3";
                lvlDesc.text = "LevelDesc";
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
