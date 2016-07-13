using UnityEngine;
using System.Collections;

public class DashAbility : MonoBehaviour
{
    private Vector2 dashVel = new Vector2(0, 0);
    private int dashVelocity = 50;
    private bool dashPuede = true;
    public float dashCooldown;
    public float dashDuration = 0.1f;
    public AudioSource dashsound;
    public float moveVelocity;
    private Animator myAnimator;  //maneja la animacion
    public PlayerController player; // lo que tenga ese script = player

    void Start()
    {
        myAnimator = GetComponent<Animator>(); //add es para la animacion del movimiento.
        player = FindObjectOfType<PlayerController>();  // unity busca al objeto con este script y lo pone en cola
        if (player.transform.localScale.x < 0)
            dashVelocity = -dashVelocity;
    }

    IEnumerator Dash(float dashDuracion)
    {
        dashPuede = false; //para que no haga cualca, lo ponemos en false
        float time=0;
        while (dashDuracion > time) //Mientras esta dasheando....
        {
            if (player.transform.localScale.x < 0)
            {
                time += Time.deltaTime;
                GetComponent<Rigidbody2D>().velocity = new Vector2(-dashVelocity, 0); ; //set our rigidbody velocity to a custom velocity every frame, so that we get a steady boost direction like in Megaman
                yield return 0; //return es ir al proximo frame!
            }
            else
            { 
                time += Time.deltaTime;
                GetComponent<Rigidbody2D>().velocity = new Vector2(dashVelocity, 0); ; //set our rigidbody velocity to a custom velocity every frame, so that we get a steady boost direction like in Megaman
                yield return 0; //return es ir al proximo frame!
            }

        }
        myAnimator.SetInteger("Dash", 0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);        
        yield return new WaitForSeconds(dashCooldown); //Cooldown!!!! esperar tiempo de cooldown!
        dashPuede = true; //ya lo puede usar de nuevo
    }

    public void Update()
    {

        if (dashPuede && Input.GetKeyDown(KeyCode.S))
        {
            myAnimator.SetInteger("Dash", 1);
            dashsound.Play();
            StartCoroutine(Dash(dashDuration)); //Le decimos que haga dash y como parametro cuanto tiempo
        }

    }
}

public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}