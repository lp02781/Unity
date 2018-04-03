using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destinations : MonoBehaviour {
	
	public void clickVacations1()
	{
		SceneManager.LoadScene ("mapContent");
	}
	public void clickVacations2()
	{
		SceneManager.LoadScene ("mapContent2");
	}
	public void menupesawat()
	{
		Debug.Log("SceneDestination");
	}
	public void menuGuide()
	{
		SceneManager.LoadScene ("guide");
	}
	public void menuPicture()
	{
		SceneManager.LoadScene ("photos");
	}
	public void menuAccount()
	{
		SceneManager.LoadScene ("account");
	}

}

