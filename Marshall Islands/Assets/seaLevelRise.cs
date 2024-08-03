using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaLevelRise : MonoBehaviour
{
    public int rate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(transform.position.x, transform.position.y+rate/1000000f, transform.position.z);
    }
}
