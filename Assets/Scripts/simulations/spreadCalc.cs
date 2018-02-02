using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreadCalc : MonoBehaviour {
    public Text InfectPercentOut; //done
    public Text InfectedOut; //done
    public Text notInfectedPercentOut;  
    public Text notInfectedOut;
    public Text cyberSecurityPercentOut;
    public Text cyberSecurityOut;
    public static ulong InfectedP;
    public static ulong notInfected;
    public static ulong notInfectedPercent;
    public static ulong CyberPercent;
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
        InfectPercentOut.text = System.Convert.ToString(InfectedP)+"%";
        //above is for infected percent

        InfectedOut.text = System.Convert.ToString(Infected);
        //above is the for infected

        notInfected = (ulong)(DataInput.population * 1000000 - Infected);
        notInfectedOut.text = System.Convert.ToString(notInfected);
        // above is not infected

        notInfectedPercent = (ulong)(100 -InfectedP);
        notInfectedPercentOut.text = System.Convert.ToString(notInfectedPercent)+"%";
        //above is not infected percent

        cyberSecurityOut.text = System.Convert.ToString(cyberPrevent);
        //above is the cyber security

        CyberPercent = (ulong)((cyberPrevent / Infected)*100U);
        cyberSecurityOut.text = System.Convert.ToString(CyberPercent)+"%";
        //this is cyber percentage 

    }



}
