using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string startLevel;

    public string levelSelect;
    public AudioSource Music;
      

    public void NewGame()
    {
        SceneManager.LoadScene(levelSelect);
        HpManager.playerHealth = 10; //added esto es nuevo
        Music.Play();
       

    }
    
    public void SaveLoadt()
    {
        SaveLoad.Load();
        Debug.Log("Se cargò el jugo como corresponde");
    }

    public void QuitGame()
    {
        Debug.Log("El juego se cerrò correctamente");
        Application.Quit();
        Music.Play();
    }
        	
	}