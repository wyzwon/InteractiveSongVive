using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollideBall : MonoBehaviour {
    GameObject innerTube;
    GameObject capsule;

    public Material hardMat;
    public Material softMat;
    public Material defaultMat;

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
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "tube")
        {
            innerTube.GetComponent<Renderer>().material = defaultMat;//defaultTexture;
        }
    }
}
