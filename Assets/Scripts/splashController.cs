using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashController : MonoBehaviour {
    public float waitTime;
    float timer = 0f;
    bool startedFadeOut = false;
    GameObject fade;

	// Use this for initialization
	void Start () {
        fade = GameObject.Find("fadeInOut");
        if (fade) {
            fade.GetComponent<fadeScript>().fadeIn();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (timer < (waitTime + fade.GetComponent<fadeScript>().fadeTime))
        {
            timer += Time.deltaTime;
        }
        else if(!startedFadeOut){
            startedFadeOut = true;
            fade.GetComponent<fadeScript>().fadeOutTo("mainMenu");
        }
	}
}