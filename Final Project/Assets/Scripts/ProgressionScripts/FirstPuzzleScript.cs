using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzleScript: MonoBehaviour
{
    public GameObject CurSwitch;
    public GameObject Fire;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            CurSwitch.SetActive(true);
            Fire.SetActive(true);
        }
        else
        {
            CurSwitch.SetActive(false);
            Fire.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoxKey")
        {
            active = false;
        }
    }
}
