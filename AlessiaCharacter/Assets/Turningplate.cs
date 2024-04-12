using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turningplate : MonoBehaviour
{
    public Vector2 rotation;
    public Transform turningPlate;

    bool buttonOn = false;

    public Animator animatorCharacter, animatorTeddy;
    public Transform teddy;

    private void Start()
    {
        teddy.gameObject.SetActive(false);
    }

    //Checkt of de button geklikt is en roteert de plaat dan
    public void Update()
    {
        if (buttonOn)
        {
            turningPlate.Rotate(0, rotation.y, 0 * Time.deltaTime);
        }
    }
    //zet bool uit en aan op basis van waar hij eerst op stond
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
   }


    //animatie voids

    public void Jump()
    {
        animatorCharacter.Play("rig|Jump");
        teddy.gameObject.SetActive(false);
    }

    public void Walking()
    {
        animatorCharacter.Play("rig|walking");
        teddy.gameObject.SetActive(false);
    }

    public void Teddy()
    {
        teddy.gameObject.SetActive(true);   
        animatorCharacter.Play("Teddy");
        animatorTeddy.Play("Teddy");
    }


}
