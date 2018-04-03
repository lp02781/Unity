using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Zombie : MonoBehaviour, IVirtualButtonEventHandler{
    // Use this for initialization
    private GameObject vbButtonObject;
    private GameObject zombie;

    void Start()
    {
        vbButtonObject = GameObject.Find("go");
        zombie = GameObject.Find("zombie");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Down");
        zombie.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Up");
        zombie.GetComponent<Animation>().Stop();
    }
    // Update is called once per frame
}