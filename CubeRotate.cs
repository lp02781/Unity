using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("a"))
		{
			transform.Rotate (new Vector3 (90, 0, 90) * Time.deltaTime);
		}
		else if(Input.GetKey("b"))
		{
			transform.Rotate (new Vector3 (0, 90, 90) * Time.deltaTime);
		}
		InvokeRepeating("loop", 5,0.5f);
	}
	void loop()
	{
		transform.Rotate (new Vector3 (90, 90, 90) * Time.deltaTime);
	}
}