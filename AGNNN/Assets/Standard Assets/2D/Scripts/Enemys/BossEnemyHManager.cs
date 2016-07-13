using UnityEngine;
using System.Collections;

public class BossEnemyHManager : MonoBehaviour
{

    public int enemyBossHealth;
    public int pointsToAdd;
    public GameObject Sangre;
    public int maxBossHealth;

    // Use this for initialization
    void Start()
    {
        enemyBossHealth = maxBossHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyBossHealth <= 0)
        {
            Instantiate(Sangre, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreManager.AddPoints(pointsToAdd);
        }

    }
    public void giveDamage(int damageToGive)
    {
        enemyBossHealth -= damageToGive;
        GetComponent<AudioSource>().Play();
    }
    public void BossFullHealth()
    {
        enemyBossHealth = maxBossHealth;
    }
}


