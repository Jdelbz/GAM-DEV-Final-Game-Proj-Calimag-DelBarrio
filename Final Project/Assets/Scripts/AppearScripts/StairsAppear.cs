using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsAppear : MonoBehaviour
{
    public GameObject Stairs;
    public bool active = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            Stairs.SetActive(true);
            
        }
        else
        {
            Stairs.SetActive(false);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            active = false;
        }
        else if (other.tag == "BoxKey")
        {
            active = true;
        }
    }
}
