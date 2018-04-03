using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideManager : MonoBehaviour {
	public int countDestination;
	public GameObject[] destination;

	void destroyAll()
	{
		for(int i = 0; i < countDestination; i++)
		{
			destination[i].SetActive(false);
		}
	}

	public void pesawat()
	{
		SceneManager.LoadScene("SceneDestination");
	}

	public void picture()
	{
		SceneManager.LoadScene("photos");
	}

	public void account()
	{
		SceneManager.LoadScene("account");
	}

	void Start()
	{
		destroyAll();
		destination[0].SetActive(true);
	}





	public void clickCity1()
	{
		destroyAll();
		destination[0].SetActive(true);
	}
	public void clickCity2()
	{
		destroyAll();
		destination[1].SetActive(true);
	}
	public void clickCity3()
	{
		destroyAll();
		destination[2].SetActive(true);
	}
	public void clickCity4()
	{
		destroyAll();
		destination[3].SetActive(true);
	}
	public void clickCity5()
	{
		destroyAll();
		destination[4].SetActive(true);
	}
	public void clickCity6()
	{
		destroyAll();
		destination[5].SetActive(true);
	}

}
