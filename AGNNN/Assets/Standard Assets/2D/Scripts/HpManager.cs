using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]

public class HpManager : MonoBehaviour {

    public static int playerHealth;
    public int maxPlayerHealth; //edited static
    public bool isDead;

    public Slider healthBar;
    
    // Text text;

    private LevelManager levelManager;

    private LifeManager lifeSystem;


	// Use this for initialization
	void Start () {
        healthBar = GetComponent<Slider>();

       //  text = GetComponent<Text>();
        playerHealth = maxPlayerHealth;
        levelManager = FindObjectOfType<LevelManager>();
        isDead = false;
        lifeSystem = FindObjectOfType<LifeManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerHealth <= 0 && !isDead)
        {
            playerHealth = maxPlayerHealth;
            levelManager.RespawnPlayer();
            lifeSystem.TakeLife();
            isDead = true;
        }

        if (playerHealth > maxPlayerHealth)
            playerHealth = maxPlayerHealth;

        // text.text = "Health Points " + playerHealth;
        healthBar.value = playerHealth;

	}


    public static void HurtPlayer(int damageToGive)

    {
        playerHealth -= damageToGive;
        
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }

}
