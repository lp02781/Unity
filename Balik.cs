using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Balik : MonoBehaviour {

	public void back()
	{
		SceneManager.LoadScene ("mapContent");
	}

	public int countPic;
	public GameObject[] pic;
	private int n = 0;

	void Start()
	{
		destroyAll();
		pic[0].SetActive(true);
		InvokeRepeating("gifFunction", 1, 1);
	}
	void Update()
	{
		setGif();
	}

	void gifFunction()
	{
		n++;
	}

	public void playVideo()
	{
		Application.OpenURL("https://www.youtube.com/watch?v=BL5Dk5-ae-o");
	} 
	void destroyAll()
	{
		for(int i = 0; i < countPic; i++)
		{
			pic[i].SetActive(false);
		}
	}

	void setGif()
	{
		if(n == 0)
		{
			destroyAll();
			pic[n].SetActive(true);
		}
		if(n == 1)
		{
			destroyAll();
			pic[n].SetActive(true);
		}
		if(n == 2)
		{
			destroyAll();
			pic[n].SetActive(true);
		}
		if(n == 3)
		{
			destroyAll();
			n = 0;
		}
	} 
}
