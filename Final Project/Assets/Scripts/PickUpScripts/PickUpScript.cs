using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
   
    float throwForce = 10;
    Vector3 objectPos;
    float distance ;

    /*public Transform theDest;*/
    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    private void Update()
    {
        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        if(distance >= 2f)
        {
            isHolding = false;
        }

        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

           
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = false;
            item.transform.position = objectPos;
        }
    }

    void OnMouseDown()
    {
        if (distance <= 2f)
        {
            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
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
