using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class userName : MonoBehaviour 
{
    public Text nameText;

    public void clickButton()
    {
        Debug.Log("userClick");
        SceneManager.LoadScene("SceneDestination");
    }

    public void getUserName(string getNameText)
    {
        nameText.text = getNameText;
    }

}