using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunkerDoor : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player1")
        {
            GameObject fade = GameManager.Instance.fadeInOutObj;
            
            if (fade) {
                fade.GetComponent<fadeScript>().fadeOutTo("island");
            }
        }

    }
}
