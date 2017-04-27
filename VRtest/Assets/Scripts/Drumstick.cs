using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drumstick : MonoBehaviour {
    
    private bool Grabbed;
    public void SetGrabbed(bool g){
        Grabbed = g;
    }
    
    void Update(){
        Dampen();    
    }
    /*
    public void Real(){
        if(!Grabbed && this.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 0){
            this.gameObject.GetComponent<Rigidbody>().velocity *= 500;
        }
    }*/
    
    public void Dampen(){
        if(!Grabbed && this.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 0){
            this.gameObject.GetComponent<Rigidbody>().velocity *= 0.99f * Time.deltaTime;//(0.01f * this.gameObject.GetComponent<Rigidbody>().velocity);
            //print("new velocity = " + this.gameObject.GetComponent<Rigidbody>().velocity.magnitude);
            if(this.gameObject.GetComponent<Rigidbody>().velocity.magnitude <= 0.00000005){
                //print("clamping to 0");
                this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
        }
    }

}
