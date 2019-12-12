using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzleScript : MonoBehaviour
{
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
            
            Fire.SetActive(true);
        }
        else
        {
            
            Fire.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            active = false;
        }
    }
}
