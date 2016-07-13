using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {


    public float Power;
    public float Radius;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Explosive")
        {
            AddExplosionForce(GetComponent<Rigidbody2D>(), Power * 100,other.transform.position, Radius);
            Debug.Log("En contacto con Explosivo");
           
        }
    }


    public static void AddExplosionForce(Rigidbody2D body, float expForce, Vector3 expPosition, float expRadius)
    {
        var dir = (body.transform.position - expPosition);
        float calc = 1 - (dir.magnitude / expRadius);
        if (calc <= 0)
        {
            calc = 0;
        }

        body.AddForce(dir.normalized * expForce * calc);
    }
   
}
