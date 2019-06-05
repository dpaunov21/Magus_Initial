using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Select : MonoBehaviour
{





    List<string> dropOptions = new List<string> { "OnlyWhileMoving", "OnlyHorizontalWhileMoving", "AlwaysAdjust", "NeverAdjust" };


    Dropdown cameraDropdownOptions;



    public CameraController camControls;












    // Start is called before the first frame update
    void Start()
    {
        // reference, clear and add options to the dropdown.
        cameraDropdownOptions = GetComponent<Dropdown>();
        cameraDropdownOptions.ClearOptions();
        cameraDropdownOptions.AddOptions(dropOptions);                                  // add the options

        camControls = FindObjectOfType<CameraController>();                             // define the cameraController scripts
        camControls.camMoveState = CameraController.CameraMoveState.NeverAdjust;        // SETS CAMERA RIG TO NEVER ADJUST
    }

    // Update is called once per frame
    void Update()
    {

        getCameraStateFromDropbox();

       // Debug.Log(cameraDropdownOptions.options[cameraDropdownOptions.value].text);   // test shit

    }




    public void getCameraStateFromDropbox()
    {
        ///////////////////
        

        if(cameraDropdownOptions.options[cameraDropdownOptions.value].text.Equals("OnlyWhileMoving"))
        {
            camControls.camMoveState = CameraController.CameraMoveState.OnlyWhileMoving;
            print("switched to only while moving");
        }


        if (cameraDropdownOptions.options[cameraDropdownOptions.value].text.Equals("OnlyHorizontalWhileMoving"))
        {
            camControls.camMoveState = CameraController.CameraMoveState.OnlyHorizontalWhileMoving;
            print("switched to only horizontal while moving");
        }

        if (cameraDropdownOptions.options[cameraDropdownOptions.value].text.Equals("AlwaysAdjust"))
        {
            camControls.camMoveState = CameraController.CameraMoveState.AlwaysAdjust;
            print("switched to always adjust");
        }

        if (cameraDropdownOptions.options[cameraDropdownOptions.value].text.Equals("NeverAdjust"))
        {
            camControls.camMoveState = CameraController.CameraMoveState.NeverAdjust;
            print("switched to never adjust");
        }





    }









}
