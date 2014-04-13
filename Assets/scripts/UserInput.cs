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
			//rigidbody.AddForce(0, 10, 0);
		}
	}
}
