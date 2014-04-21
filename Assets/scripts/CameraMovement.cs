using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform Character;
	private Transform MainCamera;
	private Vector3 cameraOffset;

	void Start ()
	{
		MainCamera = Camera.main.transform;
		cameraOffset = MainCamera.position - Character.position;
	}

	void Update ()
	{
		float x = Character.position.x + cameraOffset.x;
		float y = MainCamera.position.y;
		float z = MainCamera.position.z;
		Vector3 newPosition = new Vector3(x,y,z);
		MainCamera.position = newPosition;
	}
}
