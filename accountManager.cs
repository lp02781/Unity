using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accountManager : MonoBehaviour {

	public void menuPesawat()
	{
		SceneManager.LoadScene ("SceneDestination");
	}
	public void menuPhotos()
	{
		SceneManager.LoadScene ("photos");
	}
	public void menuGuide()
	{
		SceneManager.LoadScene ("guide");
	}
	public void menuAccount()
	{
		Debug.Log("account");
	}
}
