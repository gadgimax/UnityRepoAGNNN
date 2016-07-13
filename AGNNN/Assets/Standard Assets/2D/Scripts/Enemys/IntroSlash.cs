using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroSlash : MonoBehaviour {

    public AudioSource introSlashSound;
    public string levelToLoad;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            introSlashSound.Play();
            SceneManager.LoadScene(levelToLoad);
        }
    }

}
