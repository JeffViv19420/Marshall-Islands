using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class typingMode : MonoBehaviour
{
    public Toggle toggle;
    public TMP_InputField inputField;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.isOn){
            inputField.interactable = true;
            player.GetComponent<CameraMovement>().enabled=false;
        }
        else {
            inputField.interactable = false;
            player.GetComponent<CameraMovement>().enabled=true;
        }
    }
}
