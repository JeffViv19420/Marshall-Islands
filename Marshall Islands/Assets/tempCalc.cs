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
    public Slider HFCS;
    public Slider HCFCS;
    public Slider CFCS;
    public Slider NF3;
    public Slider SF6;
    public Slider PFCS;
    public float years;
    public double temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        years+=0.1f;
        temp = 0.000043281f*(CO2.value-284.7f)*(years-1850f)+0.028f*0.000043281f*(CH4.value-801.42f)*(years-1850f)+0.28f*0.000043281f*(N2O.value-275.4f)*(years-1850f)
                          +0.000043281f*0.0004f*(HFCS.value-122)*(years-1850f)
                          +0.000043281f*0.00012f*(HCFCS.value-230)*(years-1850f)
                          +0.000043281f*0.001f*(CFCS.value-400)*(years-1850f)
                          +0.000043281f*0.00165f*(NF3.value-1.5)*(years-1850f)
                          +0.000043281f*0.0023f*(SF6.value-9)*(years-1850f)
                          +0.000043281f*0.0007f*(PFCS.value-83)*(years-1850f);
        //tempLabel.text = (temp).ToString()+"°C";
    }
}
