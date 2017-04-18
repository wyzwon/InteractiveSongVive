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
        //audio
        GetComponent<AudioSource>().playOnAwake = false;

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
    //commented out assigning the clip to the audio source, since PlayOneShot takes the clip as an arg
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == bar1) // which bar did you hit
        {
            //GetComponent<AudioSource>().clip = sound1;
            if (col.relativeVelocity.magnitude >= HardEnough) // did you hit it hard enough
            {
                //audio
                bar1.GetComponent<AudioSource>().PlayOneShot(sound1);
            }
        }
        else if (col.gameObject == bar2)
        {
            //GetComponent<AudioSource>().clip = sound2;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar2.GetComponent<AudioSource>().PlayOneShot(sound2);
            }
        }
        else if (col.gameObject == bar3)
        {
            //GetComponent<AudioSource>().clip = sound3;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar3.GetComponent<AudioSource>().PlayOneShot(sound3);
            }
        }
        else if (col.gameObject == bar4)
        {
            //GetComponent<AudioSource>().clip = sound4;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar4.GetComponent<AudioSource>().PlayOneShot(sound4);
            }
        }
        else if (col.gameObject == bar5)
        {
            //GetComponent<AudioSource>().clip = sound5;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar5.GetComponent<AudioSource>().PlayOneShot(sound5);
            }
        }
        else if (col.gameObject == bar6)
        {
            //GetComponent<AudioSource>().clip = sound6;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar6.GetComponent<AudioSource>().PlayOneShot(sound6);
            }
        }
        else if (col.gameObject == bar7)
        {
            //GetComponent<AudioSource>().clip = sound7;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar7.GetComponent<AudioSource>().PlayOneShot(sound7);
            }
        }
        else if (col.gameObject == bar8)
        {
            //GetComponent<AudioSource>().clip = sound8;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
                bar8.GetComponent<AudioSource>().PlayOneShot(sound8);
            }
        }//ifs
    }//OnCollisionEnter
}
