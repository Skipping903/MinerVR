using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class playerPrefabHandControls : MonoBehaviour
{
    public Hand leftHand;
    public Hand rightHand;

    private SteamVR_Controller.Device leftController;
    private SteamVR_Controller.Device rightController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Was a button pressed on the left controller
        if(this.leftHand.controller != null)
        {
            this.leftController = this.leftHand.controller;

            if(this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Grip))
            {
                print("Left Grip Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad))
            {
                print("Left Touch Pad Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))
            {
                print("Left Trigger Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_DPad_Up))
            {
                print("Left D Pad UP");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_DPad_Down))
            {
                print("Left D Pad DOWN");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_DPad_Left))
            {
                print("Left D Pad LEFT");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_DPad_Right))
            {
                print("Left D Pad RIGHT");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_A))
            {
                print("Left Button A Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_ApplicationMenu))
            {
                print("Left Button Application Menu Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Axis0))
            {
                print("Left Button Axis 0 Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Axis1))
            {
                print("Left Button Axis 1 Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Axis3))
            {
                print("Left Button Axis 3 Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Axis4))
            {
                print("Left Button Axis 4 Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Dashboard_Back))
            {
                print("Left Button Dashboard Back Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Max))
            {
                print("Left Button Max Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_System))
            {
                print("Left Button System Pressed");
            }

            if (this.leftController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_ProximitySensor))
            {
                print("Left Button Proximity Sensor Pressed");
            }
        }

        //Was a button pressed on the right controller
	}
}
