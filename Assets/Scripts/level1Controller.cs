using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Controller : MonoBehaviour {
    public GameObject fade;
    public GameObject[] pumps;
    public GameObject[] valves;
    public GameObject[] floodWater;

    // Use this for initialization
    void Start()
    {
        fade = GameObject.Find("fadeInOut");
        if (fade)
        {
            GameManager.Instance.fadeInOutObj = fade;
            fade.GetComponent<fadeScript>().fadeIn();
        }

        if (GameManager.Instance.pump1L1Working) {
            
            pumps[0].GetComponent<Pump>().working = true;
            Destroy(floodWater[0]);
        }

        if (GameManager.Instance.pump2L1Working)
        {
            pumps[1].GetComponent<Pump>().working = true;
            Destroy(floodWater[1]);
        }

        if (GameManager.Instance.pump3L1Working)
        {
            pumps[1].GetComponent<Pump>().working = true;
        }

        if (GameManager.Instance.valve1L1got) Destroy(valves[0]);
        if (GameManager.Instance.valve2L1got) Destroy(valves[1]);
        if (GameManager.Instance.valve3L1got) Destroy(valves[2]);
    }
}
