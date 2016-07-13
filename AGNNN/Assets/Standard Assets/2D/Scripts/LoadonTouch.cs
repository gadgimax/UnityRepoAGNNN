using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadonTouch : MonoBehaviour {


    public string levelToLoad;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
