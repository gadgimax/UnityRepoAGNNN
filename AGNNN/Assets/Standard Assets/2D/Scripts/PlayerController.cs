using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public static float moveSpeed; //alterable por el shop
    private float moveVelocity;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private Animator myAnimator;
    public bool onLadder; // Jugador està en la zona collider de la escalera?
    public float climbSpeed; //que tan rapido sube el player por la escalera
    private float climbVelocity; 
    private float gravityStore; // graba la gravedad que tiene el player

    public bool canMove; 
    private bool grounded;
    private bool doubleJumped;
    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;


    private Rigidbody2D myrigidbody2D;

    public Transform firePoint;
    public GameObject FireBreath;
    public AudioSource jumpSound;

	// Use this for initialization
	void Start () {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        gravityStore = myrigidbody2D.gravityScale;
        canMove = true;
        myAnimator = GetComponent<Animator>(); //add es para la animacion del movimiento.
	}
	
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 
    }


	// Update is called once per frame
	void Update ()
    {
        if(!canMove)
        {
            myrigidbody2D.velocity = Vector2.zero;
            return;
                    }

        if (grounded)
        doubleJumped = false;
       
      
            if (Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                Jump();
            jumpSound.Play();
            }

            if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
            {
                Jump();
            jumpSound.Play();
            doubleJumped = true;
            }

        moveVelocity = 0f;
        myAnimator.SetInteger("speed", 0);

        if (Input.GetKey(KeyCode.D))
            {
                //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
                moveVelocity = moveSpeed;
            myAnimator.SetInteger("speed",1);
            }

            if (Input.GetKey(KeyCode.A))
            {
                moveVelocity = -moveSpeed;
                myAnimator.SetInteger("speed", 1);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }


        if (Input.GetKeyUp(KeyCode.Alpha0))  // SOLO PARA PRUEBA, DESPUES ESTO VUELA
        {
            FireController.damageToGive=1;
            LifeManager.lifeCounter++;
            LifeManager.lifeCounter++;
            LifeManager.lifeCounter++;
            HpManager.playerHealth = +10;
            PlayerController.moveSpeed = 8;
        }


        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        if (knockbackCount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
            //myrigidbody2D.velocity = new Vector2(moveVelocity, myrigidbody2D.velocity.y);
            
        }


        else
        {
            if (knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
                //myrigidbody2D.velocity = new Vector2(-knockback, knockback);

            if (!knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
                //myrigidbody2D.velocity = new Vector2(knockback, knockback);
            knockbackCount -= Time.deltaTime;

        }



        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);  // Si la velocidad X es mayor a 0 el pj mira a la derecha

        else if (GetComponent<Rigidbody2D>().velocity.x < 0) //si la velocidad X es MENOR a 0 el pj mira a la izquierda
            transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);

        if (Input.GetKeyUp(KeyCode.P))
        {
            Instantiate(FireBreath, firePoint.position, firePoint.rotation);
                                }
      if(onLadder)
        {
            myrigidbody2D.gravityScale = 0f;
            climbVelocity = climbSpeed * Input.GetAxisRaw("Vertical");
            myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, climbVelocity);

        }
            
      if(!onLadder)
        {
            myrigidbody2D.gravityScale = gravityStore;
        }   
       
    }
    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }

    void OncollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Mp")
        {
            transform.parent = other.transform;
        }
    }

    void OncollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Mp")
        {
            transform.parent = null;
        }
    }

}



