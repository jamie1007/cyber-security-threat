using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreadCalculator : MonoBehaviour {
    /*public Text InfectedP;
    public Text InfectedNumber;
    public Text NotInfectedP;
    public Text NotInfectedNumber;
    public Text CyberProtectedP;
    public Text CyberProtectedNumber;*/
    public Text[] Stats = new Text[14];
    public int InfectedTotal;
    public int NotInfected;
    public int CyberTotal;
    public int[] Percent = new int[7];
    public int[] Population = new int[4];
    public int[] Infected = new int[4];
    public int[] NewInfected = new int[4];
    public int[] CyberSecurity = new int[4];


    // Use this for initialization
    void Start() {
        DefinePopulation();
        Infected[0] = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DefinePopulation()
    {
        Population[0] = (int)(System.Convert.ToInt32(DataInput.population*10000) *5); //Cardiff
        Population[1] = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 15); //Norwich
        Population[2] = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 50);//London
        Population[3] = (int)(System.Convert.ToInt32(DataInput.population * 10000) * 30); //Edingburgh

    }
    public void Spreader()
    {
        if (Infected[0] >= Population[0] *0.9 && Infected[1] == 0 && Infected[2] == 0) //checking to see if cardiff is 90% infected
        {
            Infected[1] = 1; //setting infected
            Infected[2] = 1; 
        }
        if (Infected[1] >= Population[1]*0.9 && Infected[2] >= Population[2] *0.9 && Infected[3] == 0)
        {
            Infected[3] = 1; //setting infected
        }
        if (Infected[0] >= Population[0])
        {
            Infected[0] = Population[0];
        }
        else
        {
            NewInfected[0] = (int)Mathf.Pow(Infected[0], DataInput.spread);//spread for Cardiff
        }
        if (Infected[1] >= Population[1])
        {
            Infected[1] = Population[1];
        }
        else
        {
            NewInfected[1] = (int)Mathf.Pow(Infected[1], DataInput.spread);//spread for Norwich
        }
        if (Infected[2] >= Population[2])
        {
            Infected[2] = Population[2];
        }
        else
        {
            NewInfected[2] = (int)Mathf.Pow(Infected[2], DataInput.spread);//spread for London
        }
        if (Infected[3] >= Population[3])
        {
            Infected[3] = Population[3];
        }
        else
        {
            NewInfected[3] = (int)Mathf.Pow(Infected[3], DataInput.spread);//spread for Edingburgh
        }
    }
    public void CyberRemove()
    {
        CyberSecurity[0] = (int)(NewInfected[0] * (float)DataInput.cyberSecurity / 10); //security for Cardiff
        Mathf.Round(CyberSecurity[0]);//this rounds the number

        CyberSecurity[1] = (int)(NewInfected[1] * (float)DataInput.cyberSecurity / 10); //security for Norwich
        Mathf.Round(CyberSecurity[0]);

        CyberSecurity[2] = (int)(NewInfected[2] * (float)DataInput.cyberSecurity / 10); //security for London
        Mathf.Round(CyberSecurity[0]);

        CyberSecurity[3] = (int)(NewInfected[3] * (float)DataInput.cyberSecurity / 10); //security for Edingburgh
        Mathf.Round(CyberSecurity[0]);
    }
    public void Assignment()
    {
        InfectedTotal = (int)(Infected[1] + Infected[2] + Infected[3] + Infected[0]); //total infected number
        Stats[0].text = System.Convert.ToString(InfectedTotal);

        Percent[0] = ((InfectedTotal / System.Convert.ToInt32(DataInput.population) * 1000000) * 100);//total infected percent
        Stats[1].text = System.Convert.ToString(Percent[0]);

        NotInfected = System.Convert.ToInt32(DataInput.population) - InfectedTotal; //not infected
        Stats[2].text = System.Convert.ToString(NotInfected);

        Percent[1] = (NotInfected / InfectedTotal) * 100;
        Stats[3].text = System.Convert.ToString(Percent[1]);

        CyberTotal = (int)(CyberSecurity[1] + CyberSecurity[2] + CyberSecurity[3] + CyberSecurity[0]); //cyber
        Stats[4].text = System.Convert.ToString(CyberTotal);

        Percent[2] = (CyberTotal / (NewInfected[1] + NewInfected[2] + NewInfected[3] + NewInfected[0]));
        Stats[5].text = System.Convert.ToString(Percent[2]);

        Stats[6].text = System.Convert.ToString(Infected[2]); //london

        Percent[3] = (int)((Infected[2] / Population[2]) * 100);
        Stats[7].text = System.Convert.ToString(Percent[3]);

        Stats[8].text = System.Convert.ToString(Infected[3]); //edinburgh

        Percent[4] = (int)((Infected[3] / Population[3]) * 100);
        Stats[9].text = System.Convert.ToString(Percent[4]);

        Stats[10].text = System.Convert.ToString(Infected[1]);//norwich

        Percent[5] = (int)((Infected[1] / Population[1]) * 100);
        Stats[11].text = System.Convert.ToString(Percent[5]);

        Stats[12].text = System.Convert.ToString(Infected[0]);//cardiff

        Percent[6] = (int)((Infected[0] / Population[0]) * 100);
        Stats[13].text = System.Convert.ToString(Percent[6]);
    }
}
