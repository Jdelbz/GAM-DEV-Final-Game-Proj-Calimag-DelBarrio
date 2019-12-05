using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ShowOptionsScript : MonoBehaviour
{
    [SerializeField] private FirstPersonController fpsController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            if (ViewHandler.Instance.GetActiveView() == null)
            {
                Cursor.lockState = CursorLockMode.None;
                ViewHandler.Instance.Show("OptionPanel");
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                ViewHandler.Instance.HideCurrentView();
                // Cursor.lockState = CursorLockMode.None;
            }
        }

        /* //if (Input.GetKeyDown("escape")) {
         if (menuOpen)
         {
             if (ViewHandler.Instance.GetActiveView() == null)
             { // special case if the no is clicked
                 Debug.Log("Banana");
                 ViewHandler.Instance.Show("OptionPanel");
                 menuOpen = true;
                 //Cursor.lockState = CursorLockMode.None;
             }
             else
             {
                 ViewHandler.Instance.HideCurrentView();
                 menuOpen = false;
                 //Cursor.lockState = CursorLockMode.Confined;
             }
         }
         else if (!menuOpen)
         {
             ViewHandler.Instance.Show("OptionPanel");
             menuOpen = true;
             // Cursor.lockState = CursorLockMode.None;
         }
     }*/

        if (ViewHandler.Instance.GetActiveView() == null)
        {
            Cursor.lockState = CursorLockMode.Locked;
            fpsController.enabled = true;
        }
        else {
            Cursor.lockState = CursorLockMode.None;
            fpsController.enabled = false;
        }

        /*if (menuOpen)
        {
            fpsController.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (!menuOpen) {
            fpsController.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }*/

        //Debug.Log(ViewHandler.Instance.GetActiveView());
    }
	
	public void setMenuOpen(bool boolean){
	}
}
