using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class LampStuff : MonoBehaviour
{
    public Renderer skybox;
    public Material sky1;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public Material sky5;
    public Material sky6;

    private int currentSky = 0;

    void Start()
    {

    }

    public void stareAtLamp()
    {
        switch (currentSky)
        {
            case 0:
                skybox.material = sky2;
                currentSky++;
                break;
            case 1:
                skybox.material = sky3;
                currentSky++;
                break;
            case 2:
                skybox.material = sky4;
                currentSky++;
                break;
            case 3:
                skybox.material = sky1;
                currentSky = 0;
                break;
            case 4:
                skybox.material = sky5;
                currentSky = 0;
                break;
        }
    }

    public void rubLamp()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}