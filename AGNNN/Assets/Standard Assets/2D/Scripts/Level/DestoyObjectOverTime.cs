using UnityEngine;
using System.Collections;

public class DestoyObjectOverTime : MonoBehaviour {
    public float lifetime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
            {
            Destroy(gameObject);
        }
	}
}
