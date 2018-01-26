using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spreadCalc : MonoBehaviour {
    public int infected;
	// Use this for initialization
	void Start () {
        infected = 1;
	}
	
	// Update is called once per frame
	void Update () {
        spreadCal();
	}
    void spreadCal()
    {
        /*print(dataInput.spread);
        if (dataInput.spread == 1) 
        {
            print("ok");
       }*/
        infected = infected ^ (dataInput.spread);
        print(infected);
    }
}
