using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayerCollect : MonoBehaviour {

    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    
    // Use this for initialization
    void OnCollisionEnter(Collision collision) {
        foreach (Transform child in inventoryPanel.transform)
        {
            if (child.gameObject.tag == collision.gameObject.tag)
            {
                string c = child.Find("Text").GetComponent<Text>().text;
                int tcount = System.Int32.Parse(c) + 1;
                child.Find("Text").GetComponent<Text>().text = "" + tcount;
                return;
            }
        }

        GameObject i;
        if (collision.gameObject.tag == "Key")
        {
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);
        }
        else if (collision.gameObject.tag == "Pipe")
        {
            i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(inventoryPanel.transform);
}
        else if (collision.gameObject.tag == "Valve")
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
        }
        else if (collision.gameObject.tag == "Water")
        {
            transform.position = new Vector3(-150, 7.60f, -263);
        }

    }
}
