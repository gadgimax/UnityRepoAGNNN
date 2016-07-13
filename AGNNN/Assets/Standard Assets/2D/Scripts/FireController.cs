using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {

    public float speed;
    public PlayerController player;
    static public int damageToGive;
    public GameObject explosive;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        if (player.transform.localScale.x < 0)
            speed = -speed;
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        
	}
    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Enemy")
        {
            // Destroy(other.gameObject);
            GetComponent<AudioSource>().Play();
            other.GetComponent<EnemyHpManager>().giveDamage(damageToGive);
            Debug.Log("Hiciste" + (damageToGive));
        }

        if (other.tag == "EnemyBoss")
        {
            // Destroy(other.gameObject);
            GetComponent<AudioSource>().Play();
            other.GetComponent<BossEnemyHManager>().giveDamage(damageToGive);
            Debug.Log("Hiciste" + (damageToGive));
        }
        if (other.tag == "Rompible")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            
        }
      
        if (other.tag == "Untaged")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);
             
    }
    void OnCollider2D(Collider2D other)
    {
        Destroy(gameObject);
    }



    }

    



