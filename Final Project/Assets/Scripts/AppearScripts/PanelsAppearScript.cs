using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsAppearScript : MonoBehaviour
{
    public GameObject switches;
    public GameObject pillars;
    public GameObject Metal;
    public GameObject stone;
    public bool active;
    public bool activeswitches;
    // Start is called before the first frame update
    void Start()
    {
        activeswitches = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true && activeswitches == true)
        {
            pillars.SetActive(true);
            switches.SetActive(true);
            Metal.SetActive(false);
            stone.SetActive(false);

        }
        else if (active == true && activeswitches == false)
        {
            pillars.SetActive(true);
            switches.SetActive(false);
            Metal.SetActive(false);
            stone.SetActive(false);

        }
        else
        {
            pillars.SetActive(false);
            switches.SetActive(false);
            Metal.SetActive(false);
            stone.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            active = true;
            activeswitches = true;
        }
    }
}
