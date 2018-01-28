using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandController : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject fade = GameObject.Find("fadeInOut");
        GameObject player = GameObject.FindGameObjectWithTag("Player1");

        if (player)
        {
            if (GameManager.Instance.lastRoomPosition != Vector3.zero) {
                player.transform.position = GameManager.Instance.lastRoomPosition;
            }
        }

        if (fade)
        {
            GameManager.Instance.fadeInOutObj = fade;
            fade.GetComponent<fadeScript>().fadeIn();
        }
    }

}
