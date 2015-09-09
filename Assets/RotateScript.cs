using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
	
	public float rotationSpeed = 50;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left")) {
			transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
		}
		
		if(Input.GetKey("right")) {
			transform.RotateAround(Vector3.zero, Vector3.up, -rotationSpeed * Time.deltaTime);
		}

		if(Input.GetKey("up") && transform.localRotation.eulerAngles.z < 90.0) {
			Vector3 rightAxis = transform.TransformDirection(Vector3.right);
			transform.RotateAround(Vector3.zero, rightAxis, rotationSpeed * Time.deltaTime);
		}

		if(Input.GetKey("down") && transform.position.y > 0.0) {
			Vector3 rightAxis = transform.TransformDirection(Vector3.right);
			transform.RotateAround(Vector3.zero, rightAxis, -rotationSpeed * Time.deltaTime);
		}
	}
}
