﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler1 : MonoBehaviour {
    public Text[] stats = new Text[14]; //this is a master array which stores all the information that goes onto the screen
    public int[] Percent = new int[7]; //this is an array used to show percentages of curtain criteria
    public int[] Population = new int[4];//cardiff, norwich, london, edinburgh
    public int[] Infected = new int[7]; // total, not infected, cyber, cardiff, norwich, london, edinburgh
    public int[] NewInfected = new int[5];//cardiff, norwich, london, edinburgh, total
    public int[] CyberSecurity = new int[4]; //this is an array that stores cyber destroyed for each citiy
    public int[] populationRatio = { 5, 15, 50, 30 }; //the ratio for all cities
    public int time = 0; // this gradually increases per frame
    public int speed = 100; //this says how fast the game goes


    // Use this for initialization
    void Start () {
        DefinePopulation(); 
        Infected[3] = 1; //this is to define the first infected computer
	}
	
	// Update is called once per frame
	void Update () {
        Spreader();
        CyberRemove();




        if (time == speed) //this is slowing the game down so that it doesn't finish instantly
        {
            Spreader(); // this is calling the spreader function
            CyberRemove(); //thhis is calling the cyberRemove function
            Assignment();
            time = 0;
        }
        else
        {
            time++;//this increments the time
        }
	}
    public void DefinePopulation()
    {
        for (int i = 0; i < 4; i++)
        {
            Population[i] = (int)(System.Convert.ToInt32(DataInput.population * 1000000) * populationRatio[i]);//this is defining the population at the start of the game
        }
    }
    public void Spreader()
    {
        Infected[0] = 0; 
        NewInfected[4] = 0;//setting total newly infected to zero
        if (Infected[3] >= Population[0] * 0.9 && Infected[4] == 0 && Infected[5] == 0) //checking to see if cardiff is 90% infected
        {
            Infected[4] = 1; //setting infected
            Infected[5] = 1;
        } //if cardiff is bigger or = to 90% of cardiff's population and both norwich and london have no infected
        if (Infected[4] >= Population[1] * 0.9 && Infected[5] >= Population[2] * 0.9 && Infected[6] == 0)//if norwich is >= 90% of and london is >= 90% infected and edingburgh
        {
            Infected[6] = 1; //setting edinburgh to be equal to 1
        }
        for (int i = 0; i < 4; i++)
        {
            if (Infected[i + 3] >= (Population[i]*1000000))//+3 because the first 3 are other statistics
            {
                Infected[i + 3] = (Population[i]*1000000);//+3 because the first 3 are other statistics
            }
            else
            {
                NewInfected[i] = (int)Mathf.Pow(Infected[i + 3], DataInput.spread);
                Infected[i + 3] = Infected[i + 3] + NewInfected[i];//this is adding the newly infected to the overall infected
            }
        }
        for (int i = 0; i < 4; i++)
        {
            NewInfected[4] += NewInfected[i];
        }


    }
    public void CyberRemove()
    {
        for (int i = 0; i < 4; i++)
        {
            CyberSecurity[i] = (int)(NewInfected[i] * (float)DataInput.cyberSecurity / 10);//this is calculating the amount of computers that are not infected
            Mathf.Round(CyberSecurity[i]);//this rounds the number
            Infected[i + 3] = Infected[i + 3] - CyberSecurity[i];//this is taking the cyberSecurity from the total infected from each region
            print("infected stages1 " + i + " " + Infected[i + 3]);
        }
        for (int i = 0; i < CyberSecurity.Length; i++)
        {
            Infected[2] += CyberSecurity[i]; //this is adding up the total cyber prevented
        }

    }
    public void Assignment()
    {
        for (int i = 0; i < 4; i++)
        {
            print("infected stages2 " + i + " " + Infected[i + 3]);
            Infected[0] += Infected[i + 3];
        }
        Infected[1] = System.Convert.ToInt32(DataInput.population*1000000) - Infected[0];
        for (int i = 0; i<7; i++)
        {
            stats[i].text = System.Convert.ToString(Infected[i]);//this is applying the relevent values to the stats table
        }
        print(Infected[0]);
        Percent[0] = (Infected[0]/ System.Convert.ToInt32(DataInput.population*1000000))*100;
        Percent[1] = (Infected[0] / Infected[1] )*100;
        Percent[2] = (Infected[2] / NewInfected[4])*100;
        for (int i = 0; i < 4; i++)
        {
            Percent[i + 3] = (Infected[i + 3] / (Population[i]*1000000))*100;//this is making percentages of all of the main cities
        }
        for(int i = 0; i < 7; i++)
        {
            stats[i + 7].text = System.Convert.ToString(Percent[i]);//this is adding all the statistics values 
        }
    }
}