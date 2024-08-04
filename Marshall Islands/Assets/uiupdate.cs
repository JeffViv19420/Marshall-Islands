using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiupdate : MonoBehaviour
{
    public Toggle t;
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (t.isOn)
        {
            foreach (GameObject i in gameObjects)
            {
                i.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject i in gameObjects)
            {
                i.SetActive(false);
            }
        }
    }
}
