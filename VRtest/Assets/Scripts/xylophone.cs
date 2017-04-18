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

    //changed play to PlayOneShot in order to let multiple clips play on the one source
    //commented out assigning the clip to the audio source, since PlayOneShot takes the clip as an arg
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bar1") // which bar did you hit
        {
            //GetComponent<AudioSource>().clip = sound1;
            if (col.relativeVelocity.magnitude >= HardEnough) // did you hit it hard enough
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound1);
            }
        }
        else if (col.gameObject.tag == "bar2")
        {
            //GetComponent<AudioSource>().clip = sound2;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound2);
            }
        }
        else if (col.gameObject.tag == "bar3")
        {
            //GetComponent<AudioSource>().clip = sound3;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound3);
            }
        }
        else if (col.gameObject.tag == "bar4")
        {
            //GetComponent<AudioSource>().clip = sound4;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound4);
            }
        }
        else if (col.gameObject.tag == "bar5")
        {
            //GetComponent<AudioSource>().clip = sound5;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound5);
            }
        }
        else if (col.gameObject.tag == "bar6")
        {
            //GetComponent<AudioSource>().clip = sound6;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound6);
            }
        }
        else if (col.gameObject.tag == "bar7")
        {
            //GetComponent<AudioSource>().clip = sound7;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound7);
            }
        }
        else if (col.gameObject.tag == "bar8")
        {
            //GetComponent<AudioSource>().clip = sound8;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                GetComponent<AudioSource>().PlayOneShot(sound8);
            }
        }//ifs
    }//OnCollisionEnter
}
