using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {



    public GameObject currentCheckpoint;
    public DashAbility dash;
    private PlayerController player;
   
    public GameObject Sangre;
    public GameObject Vida;
    public float respawnDelay;
    public string levelToLoad;
    public HpManager healthManager;
    public BossEnemyHManager bossHp;
    
    // Use this for initialization


    void Start () {
        player = FindObjectOfType<PlayerController>();
        healthManager = FindObjectOfType<HpManager>();
        dash = FindObjectOfType<DashAbility>();
        bossHp = FindObjectOfType<BossEnemyHManager>();
    }
	
	// Update is called once per frame
	void Update () {

        }
            
    public void RespawnPlayer()


    {   
            StartCoroutine("RespawnPlayerCo");
        
    }
    public IEnumerator RespawnPlayerCo()

    {
        Instantiate(Sangre, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<DashAbility>().enabled = false;
        Debug.Log("El Player acaba de respawnear");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        healthManager.FullHealth();
        healthManager.isDead = false;
        Instantiate(Vida, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        player.GetComponent<DashAbility>().enabled = true;
        bossHp.BossFullHealth();

    }
       
}

