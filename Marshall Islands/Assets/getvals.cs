using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getvals : MonoBehaviour
{
    public TMP_Text parse;
    public int Co2;
    public int Ch4;
    public int N2o;
    public Slider cs;
    public Slider ch;
    public Slider ns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(parse.text.Length);
    }
    public void updateVals()
    {
        if (parse.text.Length > 20)
        {
            int.TryParse(parse.text.Substring(5, 3), out Co2);
            int.TryParse(parse.text.Substring(13, 5), out Ch4);
            int.TryParse(parse.text.Substring(24, 3), out N2o);
            cs.value*=(100+Co2)/100f;
            cs.value *= (100+Ch4)/100f;
            cs.value *= (100+N2o)/100f;
            Co2 = 0; Ch4=0; N2o = 0;
        }
    }
}
