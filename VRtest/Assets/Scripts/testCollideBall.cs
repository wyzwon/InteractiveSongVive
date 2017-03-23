using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollideBall : MonoBehaviour {
    GameObject innerTube;
    GameObject capsule;

    public Material hardMat;
    public Material softMat;
    public Material defaultMat;

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;

    public int HardEnough;

    //audio
    public AudioClip hitClip;

    // Use this for initialization
    void Start () {
        //rightRemoteBall = GameObject.FindGameObjectWithTag("rightRemoteBall");
        innerTube = GameObject.FindGameObjectsWithTag("tube")[0];
        //capsule = GameObject.FindGameObjectsWithTag("capsule")[0];
        //print(innerTube);

        //audio
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = hitClip;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tube")
        {
            print(col.relativeVelocity.magnitude);
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                innerTube.GetComponent<Renderer>().material = hardMat;
                //audio
                GetComponent<AudioSource>().Play();
            }//if hit hard enough
            else
            {
                innerTube.GetComponent<Renderer>().material = softMat;
            }
        }//if you hit the tube


        else if (col.gameObject.tag == "bar1")
        {
            print("hit");
            GetComponent<AudioSource>().clip = sound1;
            //print(col.relativeVelocity.magnitude);
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }//if hit hard enough
        }//if you hit the tube
        else if (col.gameObject.tag == "bar2")
        {
            GetComponent<AudioSource>().clip = sound2;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar3")
        {
            GetComponent<AudioSource>().clip = sound3;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar4")
        {
            GetComponent<AudioSource>().clip = sound4;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar5")
        {
            GetComponent<AudioSource>().clip = sound5;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar6")
        {
            GetComponent<AudioSource>().clip = sound6;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar7")
        {
            GetComponent<AudioSource>().clip = sound7;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
        else if (col.gameObject.tag == "bar8")
        {
            GetComponent<AudioSource>().clip = sound8;
            if (col.relativeVelocity.magnitude >= HardEnough)
            {
                //audio
				GetComponent<AudioSource>().volume = 10 / col.relativeVelocity.magnitude;
                GetComponent<AudioSource>().Play();
            }
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "tube")
        {
            innerTube.GetComponent<Renderer>().material = defaultMat;//defaultTexture;
        }
    }
}
