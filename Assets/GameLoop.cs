using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour {

    [SerializeField] private Text _globalTemp;
    public int StartingYear = 2000;
    public int CurrentYear = 0;
    public int YearsElapsed = 0;
    public float StartingGlobalTemp = 13.98f;   //in Celcius
    public float CurrentGlobalTemp = 0f;        //in Celcius
    public float CurrentRateOfChange = 0.018f;  //per annum - this should accelerate
    public float RateOfChangeMultiplier = 1f;

    private float _yearTimeInSeconds = 60f;     //1 year per minute
    private float _currentYearTime = 0f;     //1 year per minute

    //co2, methane and n20 ppm?
    //Add events list that occur when certain temps are hit - both bad and good
    //have a set amount of years to fix damage (30 years? 1 min per year?)
    //permafrost melting / freezing, stuff like that
    //major hurricane a la katrina
    //flooding
    //drought
    //snowstorm
    //mudslide
    //pandemic

    //have good actions that lower temp increase speed, and bad ones that accelerate it
    //maybe each country can have its own value for its impact, so policy change in China makes bigger difference than in UK for example

    //A MONTH A MINUTE?

    void Start() {
        CurrentGlobalTemp = StartingGlobalTemp;
        _globalTemp.text = StartingGlobalTemp.ToString("F2") + "°C";
        CurrentYear = StartingYear;
        YearsElapsed = 0;
    }

    void Update() {
        _currentYearTime += Time.deltaTime;

        if(_currentYearTime >= _yearTimeInSeconds) {
            //IncrementYear();
            //GenerateReport();  //this would be good if a minute was a month, else they would be too frequent, otherwise do decade report
            _currentYearTime = 0f;
        }

        //we should be increasing temp constantly
        //and when ending the year apply the acceleration

    }
}
