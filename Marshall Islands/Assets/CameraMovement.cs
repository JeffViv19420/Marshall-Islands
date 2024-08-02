using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")){
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x-0.1f, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
        if (Input.GetKey("s")){
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x+0.1f, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
        if (Input.GetKey("a")){
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y-0.1f, transform.localEulerAngles.z);
        }
        if (Input.GetKey("d")){
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y+0.1f, transform.localEulerAngles.z);
        }
        if (Input.GetKey("q")){
            transform.position += new Vector3(transform.forward.x*0.01f, transform.forward.y*0.01f, transform.forward.z*0.01f);
        }
        if (Input.GetKey("z")){
            transform.position -= new Vector3(transform.forward.x*0.01f, transform.forward.y*0.01f, transform.forward.z*0.01f);
        }
    }
}
