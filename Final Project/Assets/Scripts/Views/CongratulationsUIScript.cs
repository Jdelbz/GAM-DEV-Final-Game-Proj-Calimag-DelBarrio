using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CongratulationsUIScript : View
{
    // Start is called before the first frame update
    [SerializeField] private Button mainMenuBtn;
    [SerializeField] private Button nextLvlBtn;

    void Start()
    {
        Cursor.visible = true;
        if (SceneManager.GetActiveScene().name == "Level3") {
            nextLvlBtn.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
    }

    public void onMainMenuClicked() {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void nextLevelClicked() {
        switch (SceneManager.GetActiveScene().name) {
            case "Level1":
                SceneManager.LoadScene("Level2");
                break;
            case "Level2":
                SceneManager.LoadScene("Level3");
                break;
        }
    }
}
