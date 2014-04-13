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

			print("add force");
			rigidbody2D.AddForce(new Vector2(0,200));
		}
	}
}
