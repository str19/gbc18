using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Controller : MonoBehaviour {
    public GameObject fade;

    // Use this for initialization
    void Start()
    {
        fade = GameObject.Find("fadeInOut");
        if (fade)
        {
            GameManager.Instance.fadeInOutObj = fade;
            fade.GetComponent<fadeScript>().fadeIn();
        }
    }
}
