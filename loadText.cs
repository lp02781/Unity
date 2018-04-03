using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class loadText : MonoBehaviour {
	public Text textUser;

 	// Use this for initialization
 	void Start () 
 	{
  		string name = getTextFromInput.getUserName;
  		textUser.text = name;
 	}
}
