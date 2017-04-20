using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xylophone : MonoBehaviour {

    public int HardEnough;

    //each bar
    GameObject bar1;
    GameObject bar2;
    GameObject bar3;
    GameObject bar4;
    GameObject bar5;
    GameObject bar6;
    GameObject bar7;
    GameObject bar8;

    // Use this for initialization
    void Start()
    {
        bar1 = this.transform.GetChild(0).gameObject;
        bar2 = this.transform.GetChild(1).gameObject;
        bar3 = this.transform.GetChild(2).gameObject;
        bar4 = this.transform.GetChild(3).gameObject;
        bar5 = this.transform.GetChild(4).gameObject;
        bar6 = this.transform.GetChild(5).gameObject;
        bar7 = this.transform.GetChild(6).gameObject;
        bar8 = this.transform.GetChild(7).gameObject;
    }

    //changed play to PlayOneShot in order to let multiple clips play on the one source
    void OnCollisionEnter(Collision col)
    {
        //the first collision point - potential to cause problems with hitting two bars at once
        ContactPoint contact = col.contacts[0];

        //checks the two colliders in the collision to see if either is a bar
        //find out which one is true when hitting the xylophone with object and make that one the first one, so checks are more efficient
        if (contact.thisCollider.gameObject == bar1 || contact.otherCollider.gameObject == bar1)
        {
            if (col.relativeVelocity.magnitude >= HardEnough) // did you hit it hard enough
            {
                //audio
                bar1.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar2 || contact.otherCollider.gameObject == bar2)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar2.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar3 || contact.otherCollider.gameObject == bar3)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar3.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar4 || contact.otherCollider.gameObject == bar4)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar4.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar5 || contact.otherCollider.gameObject == bar5)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar5.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar6 || contact.otherCollider.gameObject == bar6)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar6.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar7 || contact.otherCollider.gameObject == bar7)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar7.GetComponent<AudioSource>().Play();
            }
        }
        else if (contact.thisCollider.gameObject == bar8 || contact.otherCollider.gameObject == bar8)
        {
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar8.GetComponent<AudioSource>().Play();
            }
        }//ifs
    }//OnCollisionEnter
}
