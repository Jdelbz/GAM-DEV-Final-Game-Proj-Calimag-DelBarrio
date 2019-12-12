using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalAppear : MonoBehaviour
{

    public GameObject Metal;
    public bool active;
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
            Metal.SetActive(true);
        }
        else
        {
            Metal.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoxKey")
        {
            active=true;
        }
    }
}
