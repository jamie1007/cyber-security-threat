using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class linkingSceneSim1 : MonoBehaviour {
    public void openPageSim() 
    {
        SceneManager.LoadScene("SimDataInput1", LoadSceneMode.Single); //this will close all pages and open the 'SimDataInput1'
    }
    public void openPageHome()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); //this will load the main menu
    }
}
