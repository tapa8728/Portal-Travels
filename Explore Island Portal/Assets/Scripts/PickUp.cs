using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        //if this works we will add more conditions on the 
        //name of the object
        if (col.gameObject.tag == "purplestar")
        {
            Destroy(col.gameObject);
        }
    }
}
