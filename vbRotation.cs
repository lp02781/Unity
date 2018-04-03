using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbRotation : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator cubeAni;
	// Use this for initialization
	void Start () {
        vbBtnObj = GameObject.Find("btn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();		
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
     
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BTN Released");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
