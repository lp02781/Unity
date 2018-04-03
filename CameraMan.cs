using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour 
{
	public Camera MainCamera;
	public Camera camera1;
	public Camera camera2;
	// Use this for initialization
	void Start () 
	{
		CameraStatus (false);
		MainCamera.GetComponent<Camera> ().enabled = true;
	}
	void CameraStatus (bool enabled)
	{
		MainCamera.GetComponent<Camera> ().enabled = enabled;
		camera1.GetComponent<Camera> ().enabled = enabled;
		camera2.GetComponent<Camera> ().enabled = enabled;
	}
	void CameraSplit()
	{
		CameraStatus (true);
		MainCamera.GetComponent<Camera> ().rect = new Rect (0, 0, 0.5f, 0.5f);
		camera1.GetComponent<Camera> ().rect = new Rect (0.5f, 0.1f, 0.5f, 1f);
		camera2.GetComponent<Camera> ().rect = new Rect (0.5f, 0.5f, 1f, 1f);
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("1")) 
		{
			CameraStatus (false);
			MainCamera.GetComponent<Camera> ().enabled = true;
			MainCamera.GetComponent<Camera> ().rect = new Rect (0, 0, 1, 1);
		}
		if (Input.GetKey ("2")) 
		{
			CameraStatus (false);
			camera1.GetComponent<Camera> ().enabled = true;
			camera1.GetComponent<Camera> ().rect = new Rect (0, 0, 1, 1);
		}
		if (Input.GetKey ("3")) 
		{
			CameraStatus (false);
			camera2.GetComponent<Camera> ().enabled = true;
			camera2.GetComponent<Camera> ().rect = new Rect (0, 0, 1, 1);
		}
	}
}
