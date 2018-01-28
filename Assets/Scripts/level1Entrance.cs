using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Entrance : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            GameObject fade = GameManager.Instance.fadeInOutObj;
            GameManager.Instance.lastRoomPosition = collision.gameObject.transform.position + new Vector3(0f,0f,-5f);
            fade.GetComponent<fadeScript>().fadeOutTo("level1");
        }
    }

}
