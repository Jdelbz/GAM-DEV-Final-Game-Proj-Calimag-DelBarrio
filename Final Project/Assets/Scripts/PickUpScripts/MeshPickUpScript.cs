using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshPickUpScript : MonoBehaviour
{
    public Transform theDest;
    // Start is called before the first frame update
    void OnMouseDown()
    {

        
        GetComponent<MeshCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

    void OnMouseUp()
    {

        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<MeshCollider>().enabled = true;
        GetComponent<Rigidbody>().detectCollisions = true;

    }
}
