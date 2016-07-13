using UnityEngine;
using System.Collections;

public class EnemyWayPoint : MonoBehaviour {
    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool wallContact;
    public float xScale;
    public float yScale;
    public float zScale;
    // Use this for initialization


    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        wallContact = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        if (wallContact)
            moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-xScale,yScale,zScale);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
        else
        {
            transform.localScale = new Vector3(xScale, yScale, zScale);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
    }
}
