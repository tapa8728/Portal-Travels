using UnityEngine;
using System.Collections;

public class waterTrigger : MonoBehaviour {
    public AudioClip clip_water;

    void OnTriggerEnter ( Collider other) {
        AudioSource.PlayClipAtPoint(clip_water, transform.position);
    }

    void OnTriggerStay (Collider other)
    {
        AudioSource.PlayClipAtPoint(clip_water, transform.position);
    }
	
	
}
