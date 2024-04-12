using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turningplate : MonoBehaviour
{
    public Vector2 rotation;
    public float speed;
    public Transform turningPlate;

    public void Update()
    {
        turningPlate.Rotate(0, rotation.y, 0 * Time.deltaTime);
    }
}
