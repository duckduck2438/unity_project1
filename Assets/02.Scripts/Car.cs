using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string Company;
    private int year;
    private string modelName;
    private bool isAccident;

    
    public void GasPedal()
    {

    }

    public void BreakerPedal()
    {


    }

    public void AI_DriveMode()
    {

    }

    public void setYear(int year)
    {
        this.year = year;
    }
    public int getYear()
    {
        return year;
    }

    public void setCompany(string company)
    {
        this.Company = company;
    }
    public string getCompany()
    {
        return Company;
    }

    public void setModelName(string modelname)
    {
        this.modelName = modelname;
    }
    public string getModelName()
    {
        return modelName;
    }

    public void setIsAccident(bool isaccident)
    {
        this.isAccident = isaccident;
    }
    public bool getIsAccident()
    {
        return isAccident;
    }


}
