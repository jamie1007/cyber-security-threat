using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Controller : MonoBehaviour {
    public Animator mainContentAnim;
    public void onHideContent() {
        mainContentAnim.SetBool("show",false);
    }
    public void onShowContent()
    {
        mainContentAnim.SetBool("show", true);
    }
}
