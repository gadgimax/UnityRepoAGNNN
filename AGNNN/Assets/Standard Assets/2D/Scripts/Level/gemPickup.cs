using UnityEngine;
using System.Collections;

public class gemPickup : MonoBehaviour
{

    public int pointsToAdd; // acà se define cuantos puntos se dan
    public AudioSource gemSoundEffect;

    void OnTriggerEnter2D(Collider2D other) //Si entra en contacto un collider 2D


    {
        if (other.GetComponent<PlayerController>() == null) //other indica que es OTRO componente que NO tenga el script "Player Controller"
            return;
        
        ScoreManager.AddPoints(pointsToAdd); //suma X puntos al script ScoreManager que se ve en la pantalla, lo puse en TEXT del canvas
        gemSoundEffect.Play();  //ejecuta el AudioSource que tenga el objeto.
        Destroy(gameObject); //destruye el objeto
    }

}