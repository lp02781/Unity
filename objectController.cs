using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour {

	public GameObject[] select;
	public int selectCount;
	// Use this for initialization
	void Start ()
	{
		for(int i = 0;i<selectCount;i++)
		{
			select[i].SetActive(false);
		}
	}
}
