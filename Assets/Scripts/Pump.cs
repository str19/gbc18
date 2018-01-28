using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pump : MonoBehaviour
{

    public GameObject water;
    bool working = false;
    int mapFlooded = 0;
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
                if(water) Destroy(water);
                switch (mapFlooded)
                {
                    case 1:
                        GameManager.Instance.firstMapFlooded = false;
                        break;
                    case 2:
                        GameManager.Instance.secondMapFlooded = false;
                        break;
                    case 3:
                        GameManager.Instance.thirdMapFlooded = false;
                        break;
                }
            }
            //Destroy(redLight);
            //greenLight.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
