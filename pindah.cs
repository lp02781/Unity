using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindah : MonoBehaviour {
	[SerializeField]
	Ray ray;
	RaycastHit hit;

	void Update (){
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit, 100) && Input.GetMouseButton (0)) {
			if (hit.collider.name == "Istanbul") {
				SceneManager.LoadScene ("Istanbil_VR");
			}
			if (hit.collider.name == "obj2") {
				SceneManager.LoadScene ("scene2");
			}
			if (hit.collider.name == "obj3") {
				SceneManager.LoadScene ("scene3");
			}
			if (hit.collider.name == "obj4") {
				SceneManager.LoadScene ("scene4");
			}
			if (hit.collider.name == "obj5") {
				SceneManager.LoadScene ("scene5");
			}
			if (hit.collider.name == "obj6") {
				SceneManager.LoadScene ("scene6");
			}
		}		
	}

	public void pindahScene (string whatScene){
		SceneManager.LoadScene (whatScene);
	}

	public void gazeClick(string whatScene){
		Invoke ("pindahScene", 3);		
	}
}
