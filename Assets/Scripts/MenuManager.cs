using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MenuManager : MonoBehaviour
{
    public CinemachineVirtualCamera mainMenuCam = null;
    public CinemachineVirtualCamera optionsCam = null;

    public void OptionsButton(){
        //cam.Follow = optionsTransform;
        //cam.LookAt = optionsTransform;
        mainMenuCam.Priority = 0;
        optionsCam.Priority = 1;
    }    

    public void MainMenuReturn(){
        //cam.Follow = menuTransform;
        //cam.LookAt = menuTransform;
        optionsCam.Priority = 0;
        mainMenuCam.Priority = 1;
    }
}
