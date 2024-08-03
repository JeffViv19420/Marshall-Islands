using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaLevelRise : MonoBehaviour
{
    public double rate;
    public tempCalc t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rate = 2.85714*t.temp+0.714286;
        transform.position= new Vector3(transform.position.x, transform.position.y+(float)(rate/100000), transform.position.z);
    }
}
