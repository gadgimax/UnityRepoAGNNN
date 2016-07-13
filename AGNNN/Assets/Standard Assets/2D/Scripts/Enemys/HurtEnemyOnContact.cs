using UnityEngine;
using System.Collections;

public class HurtEnemyOnContact : MonoBehaviour {
    public int damageToGive;

      void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GetComponent<AudioSource>().Play();
            other.GetComponent<EnemyHpManager>().giveDamage(damageToGive);
        }
    }
}
