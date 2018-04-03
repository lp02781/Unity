﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapManager : MonoBehaviour {

	public GameObject back;
	public int countContent; 
	public GameObject[] content;	

	Ray ray;
	RaycastHit hit;

	void Start()
	{
		setAllFalse();
	}

	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
		{
			clickCube();
		}
	}
	void clickCube()
	{
		if (hit.collider.name == "Cube1") 
		{
			Debug.Log("cube 1");
			setAllFalse();
			back.SetActive (true);
			contentFalse ();
			content[0].SetActive(true);
		}
		if (hit.collider.name == "Cube2") 
		{
			Debug.Log("cube 2");
			setAllFalse();
			back.SetActive (true);
			contentFalse ();
			content[1].SetActive(true);	
		}
		if (hit.collider.name == "Cube3") 
		{
			Debug.Log("cube 3");
			setAllFalse();
			back.SetActive (true);
			contentFalse ();
			content[2].SetActive(true);
		}
	}

	void contentFalse()
	{
		for(int i =0; i< countContent; i++)
		{
			content[i].SetActive(false);
		}
	}
	void setAllFalse()
	{
		back.SetActive (false);
		for(int i =0; i< countContent; i++)
		{
			content[i].SetActive(false);
		}
	}

	public void contentExit()
	{
		setAllFalse();
	}

	public void content1Detail()
	{
		Debug.Log("content 1");
		SceneManager.LoadScene("detail1");
	}

	public void content1Camera()
	{
		Debug.Log("camera 1");
	}

	public void content2Detail()
	{
		Debug.Log("content 2");
		SceneManager.LoadScene("detail2");
	}

	public void content2Camera()
	{
		Debug.Log("camera 2");
		Application.OpenURL ("https://www.youtu.be/knDBb5sR5fA");
	}
	public void content3Detail()
	{
		Debug.Log("content 3");
		SceneManager.LoadScene("detail3");
	}

	public void content3Camera()
	{
		Debug.Log("camera 3");
	}

	public void balik()
	{
		SceneManager.LoadScene ("SceneDestination");
	}
}
