using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            Invoke("GoDown", 0.2f);
        }
        
    }

    private void GoDown()
    {
        transform.Translate(0, -10f * Time.deltaTime, 0);
    }
}
