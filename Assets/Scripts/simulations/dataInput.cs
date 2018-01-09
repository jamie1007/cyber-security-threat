using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.simulations;

public class dataInput : MonoBehaviour {
    public Text spreadTxt;
    public Text cyberSecurytTxt;
    public Text populationTxt;
    public GameObject activationTxt1;
    public GameObject activationTxt2;
    public GameObject activationTxt3;
     
    public void allInputsAccepted()
    {
        if (!string.IsNullOrEmpty(spreadTxt.text) && !string.IsNullOrEmpty(cyberSecurytTxt.text) && !string.IsNullOrEmpty(populationTxt.text))
        {
            
        }
        
 
    }
    public void redBox()
    {

        if (string.IsNullOrEmpty(spreadTxt.text)) // this is checking for if the string is empty or if it has content
        {
            activationTxt1.SetActive(true);
        }

        else
        {
            activationTxt1.SetActive(false);
        }

        if (string.IsNullOrEmpty(cyberSecurytTxt.text))
        {

            activationTxt2.SetActive(true);
        }

        else
        {
            activationTxt2.SetActive(false);
        }

        if (string.IsNullOrEmpty(populationTxt.text))
        {
            activationTxt3.SetActive(true);
        }

        else
        {
            activationTxt3.SetActive(false);
        }
    }
}
