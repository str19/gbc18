using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pump : MonoBehaviour
{

    public GameObject water;
    public GameObject redLight;
    public GameObject greenLight;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            Destroy(water);
            Destroy(redLight);
            greenLight.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
