using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreadCalc : MonoBehaviour {
    public Text InfectPercent;
    public static ulong InfectedP;
    public static int Infected = 1; //this is the starting number for infected
    public static int NewInfected; // this will keep track of how many computers 
    public static float cyberPrevent; // this is the number of computers that are stopped by cyber security
    

    public void SpreadCal()
    {
        NewInfected = (int)Mathf.Pow(Infected, DataInput.spread); //this is calculating how many new computers are infected
        
        print("new infected " + NewInfected);
        Infected = Infected + NewInfected;
        
    }
    public void CyberRemove()
    {
        cyberPrevent = (int)(NewInfected * (float)DataInput.cyberSecurity/10); //this takes a percentage of the cyber security level and states how many computers don't get infected
        Mathf.Round(cyberPrevent);
        print("cyber prevented "+cyberPrevent);
        print("infected"+Infected);
        Infected = Infected - (int)cyberPrevent;
        print("final infected" + Infected);
        
    }
    public void Asignment()
    {
        InfectedP = (ulong)((Infected / (DataInput.population*1000000)*100U));//(1)
        print("percent infefected"+InfectedP);//(2)
        
    }



}
