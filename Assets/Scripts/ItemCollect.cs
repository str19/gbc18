using UnityEngine;
using UnityEngine.Playables;

public class ItemCollect : MonoBehaviour {
    
	void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Player1")
        {
            Destroy(gameObject);
        }
    }

}
