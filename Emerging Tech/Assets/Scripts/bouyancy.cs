using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouyancy : MonoBehaviour
{

    public bool underwater;
    public Rigidbody rb;
    public Vector3 y_velocity;
    public float viscosity = 0.5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {

        if (transform.position.y < -8.31) //underwater
        {

            underwater = true;
            Vector3 force = new Vector3(0, 20, 0);
            rb.AddForce(rb.velocity * -1 * viscosity);
            rb.AddForce(force);

        }

    }

}
