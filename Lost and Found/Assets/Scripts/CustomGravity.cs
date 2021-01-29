using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    Rigidbody rb;

    public Vector3 gravity = new Vector3(0, -9.8f, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //if some color condition:
        rb.AddForce(gravity);
    }
}
