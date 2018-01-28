using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeScript : MonoBehaviour {
    public float fadeTime = 2;
    int state = 3;
    string _newScene = "";

	// Use this for initialization
	void Start () {
        Color color = Color.black;
        color.a = 0f;
        gameObject.GetComponent<Image>().color = color;
	}
	
	// Update is called once per frame
	void Update () {
        Color color = gameObject.GetComponent<Image>().color;
        switch (state) {
            case 0:
                state = 3;
                gameObject.SetActive(false);
                break;
            case 1:
                if (color.a > 0f)
                {
                    color.a -= (1 / fadeTime) * Time.deltaTime;
                }
                else {
                    state = 0;
                }
                break;
            case 2:
                if (color.a < 1f)
                {
                    color.a += (1 / fadeTime) * Time.deltaTime;
                }
                else
                {
                    state = 0;
                    if (_newScene != "") SceneManager.LoadScene(_newScene);
                }
                break;
        }
        gameObject.GetComponent<Image>().color = color;
    }

    public void fadeIn() {
        gameObject.SetActive(true);
        
        Color color = Color.black;
        color.a = 1f;
        gameObject.GetComponent<Image>().color = color;
        state = 1;
    }

    public void fadeOutTo(string newScene = "") {
        gameObject.SetActive(true);

        _newScene = newScene;
        Color color = Color.black;
        color.a = 0f;
        gameObject.GetComponent<Image>().color = color;

        state = 2;
    }
}
