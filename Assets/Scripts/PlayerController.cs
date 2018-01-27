using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 25.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 25.0f;
        Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        //Vector3 movement = new Vector3(x, z*-1, 0).normalized * Time.deltaTime;
        //rb.AddForce(movement * 20);
        //transform.Rotate(0, 0, 0);
        transform.Translate(x, 0, z);
    }
}

