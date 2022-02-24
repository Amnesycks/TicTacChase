using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    Rigidbody rb;
    [Range(0.1f, 10.0f)]
    public float speed;
    private float dirZ = -1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, dirZ * speed);
    }
    
    void OnCollisionEnter(Collision target) 
    {
        if (target.gameObject.tag.Equals("Wall") == true)
        {
            dirZ *= -1f;

        }
    }
}
