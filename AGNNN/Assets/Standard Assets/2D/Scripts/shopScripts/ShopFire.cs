using UnityEngine;
using System.Collections;

public class ShopFire : MonoBehaviour {

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
                if(FireController.damageToGive <= 2)
                { 
                Yes.Play();
                ScoreManager.PointsToTake(pointsToTake);
                FireController.damageToGive++;
                }
                else
                No.Play();
                return;
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