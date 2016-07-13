using UnityEngine;
using System.Collections;

public class BossBattle : MonoBehaviour {

    public AudioSource play;
    public AudioSource stop;
    public Transform firework;
    public GameObject Fireworks;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(FindObjectOfType<BossHealthStatus>())
        {
            return;
                }
        play.Play();
        stop.Stop();
        Instantiate(Fireworks, firework.position, firework.rotation);
        Debug.Log("Inician fuegos artificiales");
        Destroy(gameObject);

    }


}
