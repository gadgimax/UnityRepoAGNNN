using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicSwitch : MonoBehaviour
{


    public AudioSource play;
    public AudioSource stop;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            stop.Stop();
            play.Play();
        }
    }
}