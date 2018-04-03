using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timedGaze : MonoBehaviour {
	[SerializeField]
	public float myTime = 0f;
	public Transform RadialProgress;
	public string whatScene;
	// Use this for initialization

	void Update () {
		myTime += Time.deltaTime;
		RadialProgress.GetComponent<Image> ().fillAmount = myTime;
		if(myTime >=3f){
			SceneManager.LoadSceneAsync (whatScene);
		}
	}
	public void Resetinator(){
		myTime = 0f;
		RadialProgress.GetComponent<Image> ().fillAmount = myTime;
	}
}
