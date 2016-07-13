using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillReloadlevel : MonoBehaviour
{
    public LevelManager levelManager;
    public DashAbility dash; // llama variable del dash
    public DashState dashState; // llama variable  estado del dash ( si es que esta en CD o dashing o ready)
    private LifeManager lifeSystem; // llama al sistema de vidas
    public string levelToLoad; // que nivel carga
    public AudioSource Break;
    public GameObject Escombros;
    public GameObject EscombrosUltra;
    public AudioSource BUM;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        dash = FindObjectOfType<DashAbility>(); // busca control del dash
        lifeSystem = FindObjectOfType<LifeManager>(); // busca script de vida
    }


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            lifeSystem.TakeLife(); // saca una vida
            SceneManager.LoadScene(levelToLoad);
            dashState = DashState.Ready; // habilita el dash nuevamente
        }
        if (other.tag == "Rompible")
        {
            Destroy(other.gameObject);
            Break.Play();
            Instantiate(Escombros, transform.position, transform.rotation);
        }
        if (other.tag == "FinRoca")
            {
            BUM.Play();
            Instantiate(EscombrosUltra, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

