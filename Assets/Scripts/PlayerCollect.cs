using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollect : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.tag == "Key")
        {
            GameManager.Instance.keysNumber++;
        }
        else if (collision.gameObject.tag == "Pipe")
        {
            GameManager.Instance.pipesNumber++;
}
        else if (collision.gameObject.tag == "Valve")
        {
            GameManager.Instance.valvesNumber++;
        }
        else if (collision.gameObject.tag == "Water")
        {
            GameManager.Instance.resetGame();
            SceneManager.LoadScene("gameOver");
        }

    }
}
