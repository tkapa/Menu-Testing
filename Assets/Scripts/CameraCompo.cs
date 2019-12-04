using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraCompo : MonoBehaviour
{

    public GameObject object1 = null;
    public GameObject object2 = null;

    bool onOff = false;

    CinemachineVirtualCamera vcam = null;

    // Start is called before the first frame update
    void Start()
    {
        if(TryGetComponent<CinemachineVirtualCamera>(out CinemachineVirtualCamera cam)){
            vcam = cam;
            vcam.Follow = object1.transform;
            vcam.LookAt = object1.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(onOff){
                vcam.Follow = object2.transform;
                vcam.LookAt = object2.transform;
                onOff = !onOff;
            } else{
                vcam.Follow = object1.transform;
                vcam.LookAt = object1.transform;
                onOff = !onOff;
            }
        }
    }
}
