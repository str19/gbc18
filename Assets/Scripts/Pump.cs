using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pump : MonoBehaviour
{

    public GameObject water;
    public bool working = false;
    public int mapFlooded = 0;
    public Sprite workingSprite;
    public Sprite notWorkingSprite;

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

                switch (gameObject.name)
                {
                    case "Pump1":
                        GameManager.Instance.pump1L1Working = true;
                        break;
                    case "Pump2":
                        GameManager.Instance.pump2L1Working = true;
                        break;
                    case "Pump3":
                        GameManager.Instance.pump3L1Working = true;
                        break;
                }
            }
        }
    }

    private void Update()
    {
        if (working) {
            gameObject.GetComponent<SpriteRenderer>().sprite = workingSprite;
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = notWorkingSprite;
        }
    }
}
