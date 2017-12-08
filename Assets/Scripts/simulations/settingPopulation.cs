using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingPopulation : MonoBehaviour {
    public InputField populationTxt;

    public void setValuePopulation() 
    {
        if (!string.IsNullOrEmpty(populationTxt.text))
        {
            populationTxt.text = "";
        }
        else
        {
            populationTxt.text = "65.64";
        }
    }
}
