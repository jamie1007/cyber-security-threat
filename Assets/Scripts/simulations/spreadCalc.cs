using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spreadCalc : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        spreadCal();
	}
    void spreadCal()
    {
        if (dataInput.spread == 1) 
        {
            print("ok");
        }
    }
}
