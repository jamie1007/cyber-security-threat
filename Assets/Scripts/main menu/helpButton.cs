using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpButton : MonoBehaviour {
    public GameObject HelpTxt; //this is a refrencer so that i can set help text visable

    public void helpTextAppear() //this is a function that can be refrenced in the unity editor 
    {
        HelpTxt.SetActive(true); // this makes the help text visable
    }
}
