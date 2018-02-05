using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreadCalculator : MonoBehaviour {
    public Text InfectedP;
    public Text InfectedNumber;
    public Text NotInfectedP;
    public Text NotInfectedNumber;
    public Text CyberProtectedP;
    public Text CyberProtectedNumber;
    public static int Infected;
    public static int NewInfected;
    public static float cyberPrevent;
    public static int CardiffPopulation;
    public static int NorwichPopulation;
    public static int LondonPopulation;
    public static int EdinburgPopulation;


    // Use this for initialization
    void Start() {
        DefinePopulation();
        Infected = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DefinePopulation()
    {
        CardiffPopulation = (int)(System.Convert.ToInt32(DataInput.population*10000) *5);
        
        NorwichPopulation = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 15);

        LondonPopulation = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 50);

        EdinburgPopulation = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 30);

    }
    public void Spreader()
    {
        NewInfected = (int)Mathf.Pow(Infected, DataInput.spread); //this is calculating how many new computers are infected
        Infected = Infected + NewInfected;
    }
    public void CyberRemove()
    {
        cyberPrevent = (int)(NewInfected * (float)DataInput.cyberSecurity / 10); //this takes a percentage of the cyber security level and states how many computers don't get infected
        Mathf.Round(cyberPrevent);
        Infected = Infected - (int)cyberPrevent;
    }
}
