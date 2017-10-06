using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody bullet;
    public float speed;


    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.forward * speed;
    }

    void Update()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            Fire();
        }
    }
}
