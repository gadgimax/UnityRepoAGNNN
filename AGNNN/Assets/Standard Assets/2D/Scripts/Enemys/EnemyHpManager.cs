using UnityEngine;
using System.Collections;

public class EnemyHpManager : MonoBehaviour {

    public int enemyHealth;
    public int pointsToAdd;
    public GameObject Sangre;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(enemyHealth <= 0 )
        {
            Instantiate(Sangre, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreManager.AddPoints(pointsToAdd);
        }
	
	}
    public void giveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
        if (GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
