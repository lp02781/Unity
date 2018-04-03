using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour
{
    public float myTime = 0f;
    [SerializeField]
    public float TriggerTime = 0f;
    public Transform RadialProgress;
    public byte countSetActiveTrue;
    public byte countSetActiveFalse;
    public GameObject[] SetActiveTrue;
    public GameObject[] SetActiveFalse;

    void Update()
    {
        myTime += Time.deltaTime;
        RadialProgress.GetComponent<Image>().fillAmount = ((1 / TriggerTime) * myTime);
        if (myTime >= TriggerTime)
        {
            for (byte i = 0; i < countSetActiveTrue; i++)
            {
                SetActiveTrue[i].SetActive(true);
            }

            for (byte i = 0; i < countSetActiveFalse; i++)
            {
                SetActiveFalse[i].SetActive(false);
            }
            myTime = 0f;
        }
    }
    public void Resetinator()
    {
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime;
    }
}
