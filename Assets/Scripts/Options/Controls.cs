using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Controls
{
    //store keycode value for inputs, if we want to change controls we can do this
    public ControlBinding forwards, backwards, strafeLeft, strafeRight, rotateLeft, rotateRight, walkRun, jump, autoRun;


    // ADD BINDING TO FIRE A WEAPON
    public ControlBinding fireProjectile;

}
