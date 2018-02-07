using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour {
    public Text[] Stats = new Text[14];
    private int[] Percent = new int[7];
    private int[] Population = new int[4];
    private int[] Infected = new int[7];
    private int[] NewInfected = new int[4];
    private int[] CyberSecurity = new int[4];
    private int[] populationRatio = { 5, 15, 50, 30};

    // Use this for initialization
    void Start () {
        /*DefinePopulation();
        Infected[0] = 1;*/
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /*public void DefinePopulation()
    {
        for (int i = 0; i < 4; i++)
        {
            Population[i] = (int)(System.Convert.ToInt32(DataInput.population * 10000) * populationRatio[i]);
        }
    }
    public void Spreader()
    {
        if (Infected[0] >= Population[0] * 0.9 && Infected[1] == 0 && Infected[2] == 0) //checking to see if cardiff is 90% infected
        {
            Infected[1] = 1; //setting infected
            Infected[2] = 1;
        }
        if (Infected[1] >= Population[1] * 0.9 && Infected[2] >= Population[2] * 0.9 && Infected[3] == 0)
        {
            Infected[3] = 1; //setting infected
        }

        for (int i = 0; i < 4; i++)
        {
            if (Infected[i] >= Population[i])
            {
                Infected[i] = Population[i];
            }
            else
            {
                NewInfected[i] = (int)Mathf.Pow(Infected[i], DataInput.spread);
                Infected[i] = System.Convert.ToInt32(Infected[i]) + NewInfected;
            }
        }
        for (int i = 0; i < Infected.Length; i++ )
        {
            Infected[6] += Infected[i];

        }
        
    }
    public void CyberRemove()
    {
        for (int i = 0; i < 4; i++)
        { 
            CyberSecurity[i] = (int)(NewInfected[i] * (float)DataInput.cyberSecurity / 10);
            Mathf.Round(CyberSecurity[i]);//this rounds the number
        }
        for (int i = 0; i<CyberSecurity.Length; i++)
        {
            totals[1] += CyberSecurity[i];
        }

    }
    public void Assignment()
    {
        totals[2] = System.Convert.ToInt32(DataInput.population) - totals[0];

        for (int i = 0; i < 3; i++)
        {
            Stats[i].text = System.Convert.ToString(totals[i]);
        }
        for (int i=3; i<7; i++)
        {
            Stats[i].text = System.Convert.ToString(Infected[i - 3]);
        }
        
        for (int i=10; i<13; i++)
        {
            Stats[i].text = System.Convert.ToString(Infected[i - 10]);
        }

    }*/
}
