using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingPopulation : MonoBehaviour {
    public InputField populationTxt;

    public void setValuePopulation() 
    {
        if (!string.IsNullOrEmpty(populationTxt.text)) //this will set the field to nothing if any number is in there
        {
            populationTxt.text = ""; //sets the text to nothing so that a number can be entered
        }
        else
        {
            populationTxt.text = "65.64"; //this will set the population to the uk population
        }
    }
}
