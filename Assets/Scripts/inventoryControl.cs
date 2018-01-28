using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryControl : MonoBehaviour {
    public GameObject[] inventoryIcons;

		
	// Update is called once per frame
	void Update () {
        Transform key = null; gameObject.transform.Find("KeyImg");
        Transform pipe = null; gameObject.transform.Find("PipeImg");
        Transform valve = null; gameObject.transform.Find("ValveImg");

        foreach (Transform child in gameObject.transform)
        {
            switch (child.gameObject.tag)
            {
                case "Key":
                    key = child;
                    break;
                case "Pipe":
                    pipe = child;
                    break;
                case "Valve":
                    valve = child;
                    break;
            }
        }

        if (key)
        {
            key.Find("Text").GetComponent<Text>().text = GameManager.Instance.keysNumber.ToString();
            if (GameManager.Instance.keysNumber == 0) Destroy(key.gameObject);
        }
        else if (GameManager.Instance.keysNumber > 0)
        {
            GameObject i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(gameObject.transform);
        }

        if (pipe)
        {
            pipe.Find("Text").GetComponent<Text>().text = GameManager.Instance.pipesNumber.ToString();
            if (GameManager.Instance.pipesNumber == 0) Destroy(pipe.gameObject);
        }
        else if(GameManager.Instance.pipesNumber > 0)
        {
            GameObject i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(gameObject.transform);
        }

        if (valve)
        {
            valve.Find("Text").GetComponent<Text>().text = GameManager.Instance.valvesNumber.ToString();
            if (GameManager.Instance.valvesNumber == 0) Destroy(valve.gameObject);
        }
        else if (GameManager.Instance.valvesNumber > 0)
        {
            GameObject i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(gameObject.transform);
        }
    }
}
