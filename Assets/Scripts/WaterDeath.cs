using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterDeath : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        print("hit");

        if (collision.gameObject.name == "Player")
        {

            print("You die");
            SceneManager.LoadScene("island");

        }

    }

}
