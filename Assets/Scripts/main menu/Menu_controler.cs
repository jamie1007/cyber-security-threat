using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_controler : MonoBehaviour {
    public Animator MenuAnim; //this is a refrance that
    public void onHideContent()//this is a function which is public so i can call it in the unity program
    {
        MenuAnim.SetBool("show", false); //this will make the boolean value in the animator false making the program hide
    }
    public void onShowContent()
    {
        MenuAnim.SetBool("show", true);
    }
}
