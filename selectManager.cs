using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectManager : MonoBehaviour {
    public float myTime = 0f;
    [SerializeField]
    public float TriggerTime = 0f;
	public Transform RadialProgress;
	public string SceneToLoad;
	// Use this for initialization

	void Update () {
		myTime += Time.deltaTime;
		RadialProgress.GetComponent<Image> ().fillAmount = ((1/TriggerTime) * myTime);
		if(myTime >=TriggerTime){
			SceneManager.LoadSceneAsync (SceneToLoad);
            myTime = 0f;
		}
	}
	public void Resetinator(){
		myTime = 0f;
		RadialProgress.GetComponent<Image> ().fillAmount = myTime;
	}
}
