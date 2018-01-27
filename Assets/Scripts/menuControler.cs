using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject fade = GameObject.Find("fadeInOut");
        fade.GetComponent<fadeScript>().fadeIn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame() {
        SceneManager.LoadScene("game");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
