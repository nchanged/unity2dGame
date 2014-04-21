using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	public float xForceMultiplier = 50f;
	public float yForceMultiplier = 200f;

	private Camera MainCamera;
	private Vector3 mouseDown = Vector3.zero;
	private Vector3 mouseUp = Vector3.zero;

	void Start ()
	{
		MainCamera = Camera.main;
	}

	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			mouseDown = MainCamera.ScreenToWorldPoint(Input.mousePosition);
		}
		if(Input.GetMouseButtonUp(0))
		{
			mouseUp = MainCamera.ScreenToWorldPoint(Input.mousePosition);

			float xForce = (mouseUp.x - mouseDown.x) * xForceMultiplier;
			float yForce = (mouseUp.y - mouseDown.y) * yForceMultiplier;
			Vector2 force = new Vector2(xForce, yForce);
			rigidbody2D.AddForce(force);
			print(force);
		}
	}
}
