using UnityEngine;
using System.Collections;

public class Instansiator : MonoBehaviour
{
    public Transform puntodespawn;
    public Transform puntodespawn1;
    public Transform puntodespawn2;
    public Transform puntodespawn3;
    public Transform puntodespawn4;
    public Transform puntodespawn5;
    public Transform puntodespawn6;
    public Transform puntodespawn7;
    public GameObject ObjectoGrabbable;
    public GameObject ObjetoAInstanciar;
    public GameObject ObjetoAInstanciar2;
    public AudioSource sonido;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            sonido.Play();
            Instantiate(ObjectoGrabbable, puntodespawn7.position, puntodespawn7.rotation);
            Instantiate(ObjetoAInstanciar, puntodespawn.position, puntodespawn.rotation);
            Instantiate(ObjetoAInstanciar, puntodespawn2.position, puntodespawn2.rotation);
            Instantiate(ObjetoAInstanciar, puntodespawn3.position, puntodespawn3.rotation);
            Instantiate(ObjetoAInstanciar, puntodespawn4.position, puntodespawn4.rotation);
            Instantiate(ObjetoAInstanciar, puntodespawn5.position, puntodespawn5.rotation);
            Instantiate(ObjetoAInstanciar2, puntodespawn6.position, puntodespawn6.rotation);
            Destroy(gameObject);
        }
    }
}