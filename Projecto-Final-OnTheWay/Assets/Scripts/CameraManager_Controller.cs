using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager_Controller : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            enableCamera(0,true);
            enableCamera(1,false);
            enableCamera(2,false);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            enableCamera(0,false);
            enableCamera(1,true);
            enableCamera(2,false);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            enableCamera(0,false);
            enableCamera(1,false);
            enableCamera(2,true);
        }
    }
    void enableCamera(int posicion, bool status)
    {
        cameras[posicion].SetActive(status);
    }
}
