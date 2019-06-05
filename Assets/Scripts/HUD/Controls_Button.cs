using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls_Button : MonoBehaviour
{

    public GameObject showGameControls;


    // show controls
    public void ShowControlsImage()
    {

            showGameControls.SetActive(true);

    }

    // hide controls
    public void HideControlsImage()
        {
        showGameControls.SetActive(false);
        }


}
