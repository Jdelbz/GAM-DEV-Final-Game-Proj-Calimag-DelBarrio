using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDisappear : MonoBehaviour
{
    public GameObject Switches;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            Switches.SetActive(true);
        }
        else
        {
            Switches.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            active = true;
        }
        else if (other.tag == "BoxKey")
        {
            active = false;
        }
    }
}
