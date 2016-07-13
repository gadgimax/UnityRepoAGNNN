using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class FireballTriggers : MonoBehaviour
{

   // public GameObject explosive;
    public int expRadius;
    public int expForce = 100;
    public int damage;
    public EnemyHpManager enemy;
    public GameObject Dynamite;
    public Transform expPoint;
    public GameObject explosionHitZone;
    public float timer;
    public bool timerOn;
    // Use this for initialization
    void Start()
    {
        enemy = FindObjectOfType<EnemyHpManager>();
        timerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timerOn = false;
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fireball")
        {
            
            Collider2D[] enemies = Physics2D.OverlapCircleAll (transform.position, expRadius, 1 << LayerMask.NameToLayer("Enemy"));
            Instantiate(Dynamite, expPoint.position, expPoint.rotation);
            explosionHitZone.SetActive(true);
            Debug.Log("En contacto con Explosivo");
            timerOn = true;
         


            foreach (Collider2D en in enemies)
            {
                // Check if it has a rigidbody (since there is only one per enemy, on the parent).
                Rigidbody2D rb = en.GetComponent<Rigidbody2D>();
                if (rb.tag == "Enemy")
                {
                    enemy.giveDamage(damage);

                }

                // Find a vector from the rocket to the enemy.
                Vector3 deltaPos = rb.transform.position - transform.position;

                // Apply a force in this direction with a magnitude of expForce.
                Vector3 force = deltaPos.normalized * expForce;
                rb.AddForce(force);
            }

           // Destroy(this.gameObject);

        }

        

    }
}
    






 

