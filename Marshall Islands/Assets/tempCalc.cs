using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tempCalc : MonoBehaviour
{
    public TMP_Text tempLabel;
    public Slider CO2;
    public Slider CH4;
    public Slider N2O;
    public int years;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempLabel.text = (0.000043281f*(CO2.value-284.7f)*(years-1850)+0.028f*0.000043281f*(CH4.value-801.42f)*(years-1850)+0.28f*0.000043281f*(N2O.value-275.4f)*(years-1850)).ToString()+"°C";
    }
}
