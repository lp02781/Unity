using UnityEngine;
using System.Collections;
 
public class CustomVirtualButtonEventHandler : MonoBehaviour , IVirtualButtonEventHandler 
{     
    ParticleSystem flames;
     
    void Start()
    {
         
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
         
        flames = GetComponentInChildren<ParticleSystem>();
 
    }
     
     
    void Update () {
     
    }
     
    public void OnButtonPressed( VirtualButtonBehaviour vb ){
         
        Debug.Log( vb.name +" Pressed" );
         
        flames.Play();
    }
     
    public void OnButtonReleased( VirtualButtonBehaviour vb ){
         
        Debug.Log( vb.name +" Released" );
         
        flames.Stop();
    }
}