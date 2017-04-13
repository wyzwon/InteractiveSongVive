using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrabObject : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private GameObject collidingObject; //grab target
    private GameObject objectInHand; //object currently being grabbed

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void SetCollidingObject(Collider col)
    {
        // if you are holding something, or the thing has no rigidbody, quit
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }
        // else set the grab target to the colliding thing
        collidingObject = col.gameObject;
    }

    // Update is called once per frame
    void Update () {
        //grabbing
        if (Controller.GetHairTriggerDown())
        {
            if (collidingObject)
            {
                GrabObject();
            }
        }

        //releasing
        if (Controller.GetHairTriggerUp())
        {
            if (objectInHand)
            {
                ReleaseObject();
            }
        }
    }

    //sets the grab target as the thing you're touching
    public void OnTriggerEnter(Collider other)
    {
        SetCollidingObject(other);
    }

    //sets the grab target at the thing you've been touching
    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
    }

    //sets the grab target as null when you release a thing
    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
    }

    //moves thing from "grab target" to "thing in hand" and slaps a fixed joint on that sucker
    private void GrabObject()
    {
        objectInHand = collidingObject;
        collidingObject = null;
        var joint = AddFixedJoint();
        joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
    }

    //attaching two rigidbodies together using fixed joints
    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        return fx;
    }

    //lets you release an object in hand
    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>())
        {
            //dismantle the fixed joint
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());
            //pass the controllers velocity and rotation when released so you can throw stuff
            objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity;
            objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
        }
        // make sure hand is empty
        objectInHand = null;
    }

}
