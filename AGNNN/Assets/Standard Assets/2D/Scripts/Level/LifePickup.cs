using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {
    private LifeManager lifeSystem;
    public AudioSource LifeSoundEffect;


    // Use this for initialization


    void Start() {
        lifeSystem = FindObjectOfType<LifeManager>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")

        {
            lifeSystem.GiveLife();
            LifeSoundEffect.Play();
            Destroy(gameObject);

        }
    }
}
