using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPickUpScript : MonoBehaviour
{
    /*Vector3 objectPos;*/
    public Transform theDest;
    /*public GameObject box;
    public bool isHolding = false;*/
    // Start is called before the first frame update

    /*private void Update()
    {
        if (isHolding == true)
        {
            box.GetComponent<Rigidbody>().velocity = Vector3.zero;
            box.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            box.transform.SetParent(theDest.transform);

           
        }
        else
        {
            objectPos = box.transform.position;
            box.transform.SetParent(null);
            box.GetComponent<Rigidbody>().useGravity = true;
            box.transform.position = objectPos;


        }
    }*/

    void OnMouseDown()
    {
       
        /*GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<MeshCollider>().enabled = false;*/
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
        /*isHolding = true;*/

    }

    void OnMouseUp()
    {

        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().detectCollisions = true;
        /*GetComponent<CapsuleCollider>().enabled = true;*/
        /*GetComponent<MeshCollider>().enabled = true;*/
        /*isHolding = false;*/
    }
}
