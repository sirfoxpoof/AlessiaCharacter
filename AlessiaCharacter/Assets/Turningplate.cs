using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turningplate : MonoBehaviour
{
    public Vector2 rotation;
    public Transform turningPlate;

    bool buttonOn = false;
    public void Update()
    {
        if (buttonOn)
        {
            ClickButton();
        }
    }

   public void ClickButton()
   {

        if(buttonOn == false)
        {
            buttonOn = true;
        }
        else
        {
            buttonOn = false;
        }
        turningPlate.Rotate(0, rotation.y, 0 * Time.deltaTime);
   }
}
