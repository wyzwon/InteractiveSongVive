using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;

	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetAxis().x != 0 || device.GetAxis().y != 0)
        {
            print(device.GetAxis().x +  ", " + device.GetAxis().y);
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            print("trigger pressed");
            device.TriggerHapticPulse(2000);
        }
	}
}
