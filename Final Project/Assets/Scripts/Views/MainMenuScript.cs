using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : View
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) {
			Application.Quit();
			Debug.Log("Application Closed");
		}
    }
	
	public void exitClicked(){
		Application.Quit();
		Debug.Log("Application Closed");
	}
	
	public void Lvl1Clicked(){
		SceneManager.LoadScene("Level1");
	}
	
	public void Lvl2Clicked(){
		SceneManager.LoadScene("Level2");
	}
	
	public void Lvl3Clicked(){
		SceneManager.LoadScene("Level3");
	}
}
