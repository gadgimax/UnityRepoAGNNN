using UnityEngine;
using System.Collections;

public class ShopLife : MonoBehaviour {

    private bool playerInZone;
    public int pointsToTake; // acà se define cuantos puntos se sacan
    public AudioSource No;
    public AudioSource Yes;

    // Use this for initialization
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && playerInZone)
        {

            if (ScoreManager.gems >= pointsToTake)
            {
                Yes.Play();
                ScoreManager.PointsToTake(pointsToTake);
                LifeManager.lifeCounter++;
            }

            else
                No.Play();
                return;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZone = false;
        }
    }
}