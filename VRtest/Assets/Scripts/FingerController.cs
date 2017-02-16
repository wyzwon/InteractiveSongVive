using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerControler : MonoBehaviour {

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObject.index); } }
    private SteamVR_TrackedObject trackedObject;

    // Use this for initialization
    void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
