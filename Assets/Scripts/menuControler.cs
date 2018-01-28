using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControler : MonoBehaviour {
    GameObject fade;
    // Use this for initialization
    void Start () {
        fade = GameObject.Find("fadeInOut");
        fade.GetComponent<fadeScript>().fadeIn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame() {
        fade.GetComponent<fadeScript>().fadeOutTo("island");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void credits()
    {
        fade.GetComponent<fadeScript>().fadeOutTo("credits");
    }
    public void menu()
    {

        fade.GetComponent<fadeScript>().fadeOutTo("mainMenu");
    }
}
