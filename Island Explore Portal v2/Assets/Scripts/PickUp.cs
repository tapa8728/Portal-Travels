using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public GUIText scoreText;
    public int purplescore;
    void OnCollisionEnter (Collision col)
    {
        //if this works we will add more conditions on the 
        //name of the object
        if (col.gameObject.tag == "purplestar")
        {
            purplescore = purplescore + 1;
            UpdateScore();
            Destroy(col.gameObject);
        }
    }

    void UpdateScore()
    {
        //scoreText.text = "Score: " + purplescore*10;
    }
}
