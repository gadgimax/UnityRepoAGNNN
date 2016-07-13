using UnityEngine;
using System.Collections;

public class BossTitle : MonoBehaviour {

    public GameObject bossTitle;
    public float titleInScreen;
    public AudioSource bosstitlesong;
    private PlayerController thePlayer;


    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.name == "Player")
        {
         StartCoroutine("Screen");
            
        }
    }


    public IEnumerator Screen()

    {
        thePlayer.canMove = false;
        bossTitle.SetActive(true);
        Time.timeScale = 0f;
        bosstitlesong.Play();
        yield return new WaitForSeconds(titleInScreen);
        bossTitle.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("La co-Rutina funciona");
        thePlayer.canMove = true;
    }




}
