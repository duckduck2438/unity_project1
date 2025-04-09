using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCar : Car
{
    // Start is called before the first frame update
    void Start()
    {
        setCompany("Tesla");
        setYear(2002);
        setModelName("ÁÁÀº Â÷");
        setIsAccident(false);
        
        Debug.Log(getCompany());
        Debug.Log(getYear());
        Debug.Log(getModelName());
        Debug.Log(getIsAccident());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
