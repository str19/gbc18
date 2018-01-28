using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pump : MonoBehaviour
{

    public GameObject water;
    bool working = false;
    //public GameObject redLight;
    //public GameObject greenLight;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            if (GameManager.Instance.valvesNumber > 0 && !working)
            {
                working = true;
                GameManager.Instance.valvesNumber--;
                Destroy(water);
            }
            //Destroy(redLight);
            //greenLight.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
