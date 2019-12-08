using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
   
    float throwForce = 10;
    Vector3 objectPos;
    float distance;

    public Transform theDest;
    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    private void Update()
    {
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions= true;
        /* GetComponent<CapsuleCollider>().enabled = false;
         GetComponent<MeshCollider>().enabled = false;
         GetComponent<BoxCollider>().enabled = false;
         GetComponent<Rigidbody>().useGravity = false;
         this.transform.position = theDest.position;
         this.transform.parent = GameObject.Find("Destination").transform;*/

    }

    void OnMouseUp()
    {
        isHolding = false;
        /*this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<CapsuleCollider>().enabled = true;
        GetComponent<MeshCollider>().enabled = true;*/
    }

    
}
