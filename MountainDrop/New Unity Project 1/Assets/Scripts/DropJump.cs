using UnityEngine;
using System.Collections;

public class DropJump : MonoBehaviour {
    private Vector3 newPosition = new Vector3(30, 30, 124);
    private Vector3 previousPosition;

    [Tooltip("The speed at which he will jump")]
    public float speed;

    //only for testing without cardboard.
    [Tooltip("Activate this checkbox if the player shall move when the Cardboard trigger is pulled.")]
    public bool walkWhenTriggered;

    CardboardHead head = null;
    // Use this for initialization
    void Start () {
        head = Camera.main.GetComponent<StereoController>().Head;
    }
	
	// Update is called once per frame
	void Update () {

        if (walkWhenTriggered)// && Cardboard.SDK.Triggered)
        {
            speed = speed + 0.1f;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, newPosition, step);
        }
    }
}
