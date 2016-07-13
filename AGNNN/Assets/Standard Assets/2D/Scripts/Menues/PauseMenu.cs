using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class PauseMenu : MonoBehaviour {

    public string levelSelect;

    public string MainMenu;

    public bool isPaused;
    private PlayerController thePlayer; //invoca control

    public GameObject pauseMenuCanvas;

    public AudioSource MENUA_Select; 

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();

    }
	
	// Update is called once per frame
	void Update () {
	if(isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.volume = 0.1f;
            thePlayer.canMove = false;
        }
    else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
            AudioListener.volume = 1f;
            thePlayer.canMove = true;
        }
    if(Input.GetKeyDown(KeyCode.Escape))
        {
            MENUA_Select.Play();
            isPaused = !isPaused;

        }
    }
    public void Resume()
    {
        isPaused = false;
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }
    public void Quit()
    {
        isPaused = false;  // si esto no se coloca, cuando se quitea el juego, la musica y los controles estan desactivados.
        SceneManager.LoadScene(MainMenu);
        //Application.LoadLevel(MainMenu);  // no se usa mas esta WEA
    }

    public void SaveLoadt()
    {
        SaveLoad.Save();
        Debug.Log("Se salvò el jugo como corresponde");
    }

}
