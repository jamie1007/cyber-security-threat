using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class linkingSceneSim : MonoBehaviour {
    public void openPageSim1() 
    {
        SceneManager.LoadScene("SimDataInput1", LoadSceneMode.Single); //this will close all pages and open the 'SimDataInput1'
    }
    public void openPageSim2()
    {
        SceneManager.LoadScene("SimDataInput2", LoadSceneMode.Single); //this will load the second page for simulation 2 and close all other pages
    }
    public void openPageSim3()
    {
        SceneManager.LoadScene("SimDataInput3", LoadSceneMode.Single); //this is the same as the other two but with sim 3
    }
    public void openPageHome()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); //this will load the main menu
    }

}
