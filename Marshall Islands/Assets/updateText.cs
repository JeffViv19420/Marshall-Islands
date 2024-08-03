using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updateText : MonoBehaviour
{
    public TMP_Text t1;
    public TMP_Text t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t1.text=t2.text;
    }
}
