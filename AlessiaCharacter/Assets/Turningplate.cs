using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turningplate : MonoBehaviour
{
    public Vector2 rotation;

    public Transform turningPlate;

    public void RotateX()
    {
        //rotation.x = Input.GetAxis("Mouse X");
        //rotation.y = Input.GetAxis("Mouse Y");

        turningPlate.Rotate(rotation.x, 0, 0);
        /*if (Input.GetMouseButton(0))
        {
        }*/

        Debug.Log("AAAAAAAAAA");
    }
}
