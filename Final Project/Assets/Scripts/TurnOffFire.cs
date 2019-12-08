using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffFire : MonoBehaviour
{

    public GameObject fire;
    public GameObject fireblocker;
    public GameObject pillars;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            pillars.SetActive(true);
        }
        else
        {
            pillars.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BoxKey")
        {
            Object.Destroy(fire);
            Object.Destroy(fireblocker);
            active = false;
        }
        else if(other.tag == "Player")
        {
            Object.Destroy(fire);
            Object.Destroy(fireblocker);
            active = true;
        }
    }
}
