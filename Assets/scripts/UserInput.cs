using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	void Start ()
	{
	
	}

	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			rigidbody2D.AddForce(new Vector2(50,200));
		}
	}
}
