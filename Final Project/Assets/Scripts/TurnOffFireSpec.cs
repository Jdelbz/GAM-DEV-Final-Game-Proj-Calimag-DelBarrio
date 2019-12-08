using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffFireSpec : MonoBehaviour
{

    public GameObject fire;
    public GameObject fireblocker;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoxKey")
        {
            Object.Destroy(fire);
            Object.Destroy(fireblocker);
            
        }
        else if (other.tag == "Player")
        {
            Object.Destroy(fire);
            Object.Destroy(fireblocker);
        }
    }
}
