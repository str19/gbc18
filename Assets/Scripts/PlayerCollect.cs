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
            switch (collision.gameObject.name) {
                case "valve1":
                    GameManager.Instance.valve1L1got = true;
                    break;
                case "valve2":
                    GameManager.Instance.valve2L1got = true;
                    break;
                case "valve3":
                    GameManager.Instance.valve3L1got = true;
                    break;
            }
            GameManager.Instance.valvesNumber++;
        }
        else if (collision.gameObject.tag == "Water")
        {
            GameManager.Instance.resetGame();
            SceneManager.LoadScene("gameOver");
        }

    }
}
