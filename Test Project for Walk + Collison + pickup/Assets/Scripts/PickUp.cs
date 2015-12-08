using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
         Destroy(other.gameObject);
        
    }

    
}
