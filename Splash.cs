using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour 
{
	public GUISkin mySkin;
	bool value = true;
	public string WhatScene;
	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
	}
	void OnGUI()
	{
		GUI.skin = mySkin;
		value = GUI.Toggle (new Rect (20, 20, 60, 60), value, "");
		if (GUI.Button (new Rect (20, Screen.height - 70, Screen.width-1000, 60), "mulai")) 
		{
			Destroy(gameObject);
		}
		if (GUI.Button (new Rect (1000, Screen.height - 70, Screen.width-1000, 60), "keluar")) 
		{
			Application.Quit ();
		}
	}
}
