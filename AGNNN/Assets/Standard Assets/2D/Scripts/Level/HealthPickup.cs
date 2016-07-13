using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour
{

    public int healthToGive;
    public AudioSource SoundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;
        else
        {
            HpManager.HurtPlayer(-healthToGive);
            SoundEffect.Play();
            Destroy(gameObject);
        }
    }
}