using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {



    public LevelManager levelManager;
    public DashAbility dash; // llama variable del dash
    public DashState dashState; // llama variable  estado del dash ( si es que esta en CD o dashing o ready)
    private LifeManager lifeSystem; // llama al sistema de vidas



    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        dash = FindObjectOfType<DashAbility>(); // busca control del dash
        lifeSystem = FindObjectOfType<LifeManager>(); // busca script de vida
    }


    void Update() {
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.name == "Player")
        {
            lifeSystem.TakeLife(); // saca una vida
            levelManager.RespawnPlayer();
            dashState = DashState.Ready; // habilita el dash nuevamente
        }

    }
}
