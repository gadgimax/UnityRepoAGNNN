using UnityEngine;
using System.Collections;

public class Explodo : MonoBehaviour {


    public float radius = 5;
    public float power = 5;
    public float upwardForce = 0;

    private float radiusUsed = 0.5F;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Applies an explosion force to all nearby rigidbodies
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

        foreach (Collider hit in colliders)
        {
            if (hit == null)
                continue;
            if (hit.GetComponent<Rigidbody>())
            {
                hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radiusUsed, upwardForce);
            }
        }
        radiusUsed = ((radius - radiusUsed) / 2) * Time.deltaTime;
    }

    // Auto destroy	
    public float timeOut = 1.0F;

    void Awake()
    {
        Invoke("DestroyNow", timeOut);
    }

    void DestroyNow()
    {

        DestroyObject(gameObject);
    }


}