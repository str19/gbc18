using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove3D : MonoBehaviour {

	float xMove;
	float yMove;
	public float moveSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		xMove = Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime;
		yMove = Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime;

		//transform.Translate (xMove, 0, yMove);
		transform.Translate (xMove, 0, yMove);
	}


}
