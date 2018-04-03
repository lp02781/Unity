using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getTextFromInput : MonoBehaviour {
 	static public string getUserName;
 	public InputField mainInputField;
 	
  void Start()
 	{
  		mainInputField.text = "";
  		getUserName = null;
 	}
 	void Update()
 	{
 		getUserName = mainInputField.text;
  		if (getUserName != null)
  		{
   			if (Input.GetKeyDown(KeyCode.P))
   			{
   				Debug.Log ("You Have Inputted: " + getUserName);
   			}
  		}
  		else
  		{
   			Debug.Log ("Not entered!");
   		}
  	}
  public void clickButton()
  {
    SceneManager.LoadScene("SceneDestination");
  }
}
