using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadCalculator : MonoBehaviour {

    public static int CardiffPopulation;
    public static int NorwichPopulation;
    public static int LondonPopulation;
    public static int EdinburgPopulation;


    // Use this for initialization
    void Start() {
        DefinePopulation();
    }

    // Update is called once per frame
    void Update() {

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

    }
}
