using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public GUIText scoreText;
    
    public AudioClip clip_purple;
    public AudioClip clip_red;

    public Text countText_left;
    public Text countText_right;
    public int purplescore;
    void OnCollisionEnter (Collision col)
    {
        //if this works we will add more conditions on the 
        //name of the object
        if (col.gameObject.tag == "purplestar")
        {
            purplescore = purplescore + 1;
            UpdateScore();
            AudioSource.PlayClipAtPoint(clip_purple, transform.position);
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "redstar")
        {
            purplescore = purplescore + 5;
            UpdateScore();
            AudioSource.PlayClipAtPoint(clip_red, transform.position);
            Destroy(col.gameObject);
        }
    }

    void UpdateScore()
    {
        countText_left.text = "Score: " + purplescore*10;
        countText_right.text = "Score: " + purplescore * 10;
    }
}
