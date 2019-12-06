using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Level1":
                SceneManager.LoadScene("Level2");
                break;

            case "Level2":
                SceneManager.LoadScene("Level3");
                break;
            case "Level3":
                SceneManager.LoadScene("MainMenuScene");
                break;

        }

       /* if (SceneManager.GetActiveScene().name == "Level2")
            SceneManager.LoadScene(3);*/
    }

}
