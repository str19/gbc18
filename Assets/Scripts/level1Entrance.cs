using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Entrance : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            GameObject fade = GameManager.Instance.fadeInOutObj;
            fade.GetComponent<fadeScript>().fadeOutTo("level1");
        }
    }

}
