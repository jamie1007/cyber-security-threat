using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.simulations;
using UnityEngine.SceneManagement;

public class DataInput : MonoBehaviour {
    public Text spreadTxt;
    public Text cyberSecurytTxt;
    public Text populationTxt;
    public GameObject activationTxt1;
    public GameObject activationTxt2;
    public GameObject activationTxt3;
    public static float spread;
    public static int cyberSecurity;
    public static float population;


    public void AllInputsAccepted()
    {
        if (!string.IsNullOrEmpty(spreadTxt.text) && !string.IsNullOrEmpty(cyberSecurytTxt.text) && !string.IsNullOrEmpty(populationTxt.text)
            && !(System.Convert.ToInt32(spreadTxt.text) <= 0 || System.Convert.ToInt32(spreadTxt.text) >= 101) 
            && !(System.Convert.ToInt32(cyberSecurytTxt.text) <= 0 || System.Convert.ToInt32(cyberSecurytTxt.text) >= 11))
        {
            print("ok");
            SceneManager.LoadScene("Sim1", LoadSceneMode.Single);
        }
    }
    public void RedBox()
    {
        if (string.IsNullOrEmpty(spreadTxt.text)) // this is checking for if the string is empty or if it has content
        {
            activationTxt1.SetActive(true);
        }

        else
        {
            activationTxt1.SetActive(false);
            spread = System.Convert.ToInt32(spreadTxt.text);
            
        }

        if (string.IsNullOrEmpty(cyberSecurytTxt.text))
        {

            activationTxt2.SetActive(true);
        }

        else
        {
            activationTxt2.SetActive(false);
            cyberSecurity = System.Convert.ToInt32(cyberSecurytTxt.text);
        }

        if (string.IsNullOrEmpty(populationTxt.text))
        {
            activationTxt3.SetActive(true);
        }

        else
        {
            activationTxt3.SetActive(false);
            population = System.Convert.ToInt32(populationTxt.text);
        }
        if (System.Convert.ToInt32(spreadTxt.text) <= 0 || System.Convert.ToInt32(spreadTxt.text) >= 101)
        {
            activationTxt1.SetActive(true);
        }
        else 
        {
            activationTxt1.SetActive(false);
        }
        if (System.Convert.ToInt32(cyberSecurytTxt.text) <= 0 || System.Convert.ToInt32(cyberSecurytTxt.text) >= 11)
        {
            activationTxt2.SetActive(true);
        }
        else
        {
            activationTxt2.SetActive(false);
        }
    }
}
