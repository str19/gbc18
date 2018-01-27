using UnityEngine;

public class ItemCollect : MonoBehaviour {
 
	void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Player1")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }

}
