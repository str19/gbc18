using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandController : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject fade = GameObject.Find("fadeInOut");
        if (fade)
        {
            GameManager.Instance.fadeInOutObj = fade;
            fade.GetComponent<fadeScript>().fadeIn();
        }
    }
}
