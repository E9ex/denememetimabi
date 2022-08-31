using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmmm : MonoBehaviour
{
  public Rigidbody rb;
  public float bulletspeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletspeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
