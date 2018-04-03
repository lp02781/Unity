using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeObject : MonoBehaviour
{
    public GameObject objek1, objek2, objek3;
    public GameObject[] objek3D = new GameObject[3];
    public int no = 1;

    public void Start()
    {
        object3D [0] = objek1;
        object3D [1] = objek2;
        object3D [2] = objek3;
    }

    public void OnGUI()
    {
        if(GUI.Button(new Rect(150,40,100,60), "NEXT"))
        {
            nextObject();
        }
        if(GUI.Button(new Rect(20,40,100,40), "PREV"))
        {
            prevObject();
        }
    }

    public void nextObject()
    {
        if(no < 3)
        {
            no++;
        }

    }

    public void prevObject()
    {
        if(no > 1)
        {
            no--;
        }
    }

    public void Update()
    {
        if(no ==1)
        {
            objek1.SetActive(true);
            objek2.SetActive(false);
            objek3.SetActive(false);
        }
        if(no ==2)
        {
            objek1.SetActive(false);
            objek2.SetActive(true);
            objek3.SetActive(false);
        }
        if(no ==3)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(true);
        }
    }
}