using UnityEngine;
using System.Collections;

public class ShopSpeed : MonoBehaviour {
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
                if (PlayerController.moveSpeed <= 16)
                {
                    Yes.Play();
                    ScoreManager.PointsToTake(pointsToTake);
                    PlayerController.moveSpeed ++;
                    PlayerController.moveSpeed++;
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