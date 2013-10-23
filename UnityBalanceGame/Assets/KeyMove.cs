using UnityEngine;
using System.Collections;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// reverse rotation from the textbook
		// for Keyboard
		/*
		transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 30.0f * Time.deltaTime, new Vector3( 0.0f, 0.0f, -1.0f));
		transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Vertical")   * 30.0f * Time.deltaTime, new Vector3(-1.0f, 0.0f,  0.0f));
		*/
		// for iOS
		transform.rotation = 
			Quaternion.AngleAxis(Input.acceleration.x * 60, new Vector3( 0.0f, 0.0f, -1.0f)) *
			Quaternion.AngleAxis(Input.acceleration.y * 60, new Vector3( 1.0f, 0.0f,  0.0f));
	}
}
