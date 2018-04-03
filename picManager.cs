using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class picManager : MonoBehaviour {
	public GameObject blurBackGround;
	public int countContent;
	public GameObject[] content;


	void Start()
	{
		destroyAll();
	}

	void destroyAll()
	{
		blurBackGround.SetActive(false);
	}
	void destroyContents()
	{
		for(int i = 0; i < countContent; i++)
		{
			content[i].SetActive(false);
		}
	}
	public void exit()
	{
		destroyAll();
	}
	//click Menu
	public void menuPesawat()
	{
		Debug.Log("menu pesawat");
		SceneManager.LoadScene ("SceneDestination");
	}
	public void menuPhotos()
	{
		Debug.Log("menu photo");
	}
	public void menuGuide()
	{
		SceneManager.LoadScene ("guide");
	}
	public void menuAccount()
	{
		SceneManager.LoadScene ("account");
	}

	//click Tag
	public void clickTag1()
	{
		Debug.Log("tag 1 click");
	}
	public void clickTag2()
	{
		Debug.Log("tag 2 click"); 
	}
	public void clickTag3()
	{
		Debug.Log("tag 3 click");
	}
	public void clickTag4()
	{
		Debug.Log("tag 4 click");
	}

	//vlivk Picture
	public void clickPic1()
	{
		destroyAll();
		blurBackGround.SetActive(true);
		destroyContents();
		content[0].SetActive(true);
	}
	public void clickPic2()
	{
		destroyAll();	
		blurBackGround.SetActive(true);
		destroyContents();
		content[1].SetActive(true);
	}
	public void clickPic3()
	{
		destroyAll();
		blurBackGround.SetActive(true);
		destroyContents();
		content[2].SetActive(true);
	}
}