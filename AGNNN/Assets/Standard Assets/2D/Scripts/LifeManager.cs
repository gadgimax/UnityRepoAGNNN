using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;





public class LifeManager : MonoBehaviour {
    

    public static LifeManager current;
    public static int startingLives;  
    public static int lifeCounter;
    public string gameOverLevel;
    private Text theText;
   
    
	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();

        // lifeCounter = startingLives;  // Si pongo esto, no se carrea entre escenas. 

        
	}
	
	// Update is called once per frame
	void Update() { 

        if(lifeCounter < 0)
        {
                      SceneManager.LoadScene(gameOverLevel);
                      lifeCounter = 0;
        }

        theText.text = "x " + lifeCounter;
	}
    public void GiveLife()
    {
        lifeCounter++;
    }
    public void TakeLife()
    {
        lifeCounter--;

    }
}
