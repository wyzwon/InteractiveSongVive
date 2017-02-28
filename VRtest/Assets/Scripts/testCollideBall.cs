using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollideBall : MonoBehaviour {
    GameObject innerTube;
    GameObject capsule;
    Texture defaultTexture;

    public Material hardMat;
    public Material softMat;

    //audio
    public AudioClip hitClip;

    // Use this for initialization
    void Start () {
        //rightRemoteBall = GameObject.FindGameObjectWithTag("rightRemoteBall");
        innerTube = GameObject.FindGameObjectsWithTag("tube")[0];
        //capsule = GameObject.FindGameObjectsWithTag("capsule")[0];
        //print(innerTube);
        defaultTexture = innerTube.GetComponent<Renderer>().material.mainTexture;

        //audio
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = hitClip;
    }
	
	// Update is called once per frame
	void Update () {
        /*print(Vector3.Distance(innerTube.transform.position, this.transform.position));
        print("innerTube: " + innerTube.transform.position);
        print("This: " + this.transform.position);

        capsule.transform.position = this.transform.position;
        if (Vector3.Distance(innerTube.transform.position, this.transform.position) < 8)
        {
            innerTube.GetComponent<Renderer>().material.mainTexture = myNewTexture2D;
            print("detected proximity within 8 units");
        }//this.gameObject.transform)*/
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tube")
        {
            if (col.relativeVelocity.magnitude >= 1)
            {
                innerTube.GetComponent<Renderer>().material = hardMat;
            }//if hit hard enough
            else
            {
                innerTube.GetComponent<Renderer>().material = softMat;
            }

            //audio
            GetComponent<AudioSource>().Play();
        }//if you hit the tube
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "tube")
        {
            innerTube.GetComponent<Renderer>().material.mainTexture = defaultTexture;
        }
    }
}
