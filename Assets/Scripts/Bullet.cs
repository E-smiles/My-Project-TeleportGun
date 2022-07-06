using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    public float x;
    public float timeBetweenSpawns;
    private float timer;
    
    //public GameObject prefab;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);
        //timer = timeBetweenSpawns;
    }

    void Update()
    {
        //Code temporaire//
        // {
        //     timer -= Time.deltaTime;
        //     if(timer <=0)
        //     {
        //         timer = timeBetweenSpawns;
        //         // Instantiate(prefab, playerTransform.position, Quaternion.identity);
        //     }
        // }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Bounce")
        {
            ContactPoint cp = collision.GetContact(0);
            if(Vector3.Angle(cp.normal, Vector3.up) <=45)//angle entre la normale et la verticale est plus grand que 45
            playerTransform.position = collision.GetContact(0).point;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    // void FixedUpdate()
    // {
    //     if (rb.IsSleeping()){
    //         force += x;
    //         rb.AddForce(Vector3.up * force);
    //     }
    // }
}
