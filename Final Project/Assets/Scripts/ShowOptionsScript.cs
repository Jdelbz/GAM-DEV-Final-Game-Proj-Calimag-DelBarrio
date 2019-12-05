using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOptionsScript : MonoBehaviour
{
	bool menuOpen = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) {
			if(menuOpen){
				if(ViewHandler.Instance.GetActiveView() == null){ // special case if the no is clicked
					ViewHandler.Instance.Show("OptionPanel");
					menuOpen = true;
                    Cursor.lockState = CursorLockMode.None;
				}
				else {
				ViewHandler.Instance.HideCurrentView();
				menuOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
                }
			}
			else if(!menuOpen){
				ViewHandler.Instance.Show("OptionPanel");
				menuOpen = true;
			}
		}
		
    }
	
	public void setMenuOpen(bool boolean){
		menuOpen = boolean;
	}
}
