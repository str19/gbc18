using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            if (GameManager.Instance.keysNumber > 0)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                this.GetComponent<MeshRenderer>().enabled = false;

                GameManager.Instance.keysNumber--;
            }
        }
    }
}
