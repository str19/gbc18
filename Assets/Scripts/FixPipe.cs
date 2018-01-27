using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FixPipe : MonoBehaviour
{
    public GameObject inventoryPanel;

    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            foreach (Transform child in inventoryPanel.transform)
            {
                if (child.gameObject.tag == "Pipe")
                {
                    this.GetComponent<BoxCollider>().enabled = false;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    string c = child.Find("Text").GetComponent<Text>().text;
                    if (System.Int32.Parse(c) > 1)
                    {
                        int tcount = System.Int32.Parse(c) - 1;
                        child.Find("Text").GetComponent<Text>().text = "" + tcount;
                        this.GetComponent<BoxCollider>().enabled = false;
                        this.GetComponent<MeshRenderer>().enabled = false;
                    }
                    else if (System.Int32.Parse(c) > 0)
                    {
                        int tcount = System.Int32.Parse(c) - 1;
                        child.Find("Text").GetComponent<Text>().text = "" + tcount;
                        this.GetComponent<BoxCollider>().enabled = false;
                        this.GetComponent<MeshRenderer>().enabled = false;
                        Destroy(child);
                    }
                    return;
                }
            }

        }
    }
}
