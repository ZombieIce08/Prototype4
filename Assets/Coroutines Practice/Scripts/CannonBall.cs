using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{

    public float launchForce;
    public Rigidbody rb;
    public float forwardForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * launchForce + Vector3.forward * forwardForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
