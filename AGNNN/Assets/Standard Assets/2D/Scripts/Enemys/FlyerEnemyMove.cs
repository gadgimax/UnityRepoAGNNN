using UnityEngine;
using System.Collections;

public class FlyerEnemyMove : MonoBehaviour {


    private PlayerController thePlayer;
    public float moveSpeed;
    public float playerRange;
    public LayerMask playerLayer;
    public bool playerInRange;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer); 
  
        if (playerInRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, moveSpeed * Time.deltaTime);
        }

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(7f, 7f, 7f);  // Si la velocidad X es mayor a 0 el pj mira a la derecha

        else if (GetComponent<Rigidbody2D>().velocity.x < 0) //si la velocidad X es MENOR a 0 el pj mira a la izquierda
            transform.localScale = new Vector3(-7f, 7f, 7f);
    }
    void OndrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, playerRange);
    }
}
