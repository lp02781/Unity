using System.Collections;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Update is called once per frame
    public int angleX;
    public int angleY;
    public int angleZ;
    void Update ()
    {
        transform.Rotate (new Vector3 (angleX, angleY, angleZ) * Time.deltaTime);
	}
}
