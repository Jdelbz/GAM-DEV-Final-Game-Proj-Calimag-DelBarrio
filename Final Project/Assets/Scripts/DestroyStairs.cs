using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStairs : MonoBehaviour
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
        if (active == false)
        {
            Object.Destroy(Stairs);
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
