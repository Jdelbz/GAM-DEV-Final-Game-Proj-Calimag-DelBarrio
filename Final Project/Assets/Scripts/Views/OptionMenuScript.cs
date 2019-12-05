using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class OptionMenuScript : View
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	public void returnMainMenuPressed(){
        SceneManager.LoadScene("MainMenuScene");
    }
	
	public void returnToGamePressed(){
        ViewHandler.Instance.HideCurrentView();
    }
}
