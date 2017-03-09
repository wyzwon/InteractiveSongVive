using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xylophone : MonoBehaviour {

    public int HardEnough;

    //audio
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;

    // Use this for initialization
    void Start()
    {
        //audio
        GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = sound1;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bar1")
        {
            GetComponent<AudioSource>().clip = sound1;
            //print(col.relativeVelocity.magnitude);
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }//if hit hard enough
        }//if you hit the tube
        else if (col.gameObject.tag == "bar2")
        {
            GetComponent<AudioSource>().clip = sound2;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar3")
        {
            GetComponent<AudioSource>().clip = sound3;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar4")
        {
            GetComponent<AudioSource>().clip = sound4;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar5")
        {
            GetComponent<AudioSource>().clip = sound5;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar6")
        {
            GetComponent<AudioSource>().clip = sound6;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar7")
        {
            GetComponent<AudioSource>().clip = sound7;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar8")
        {
            GetComponent<AudioSource>().clip = sound8;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
