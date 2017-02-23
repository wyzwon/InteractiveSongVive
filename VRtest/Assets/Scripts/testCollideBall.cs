using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollideBall : MonoBehaviour {
    GameObject innerTube;
    GameObject capsule;
    Texture defaultTexture;

    public Texture2D myNewTexture2D;
    // Use this for initialization
    void Start () {
        //rightRemoteBall = GameObject.FindGameObjectWithTag("rightRemoteBall");
        innerTube = GameObject.FindGameObjectsWithTag("tube")[0];
        capsule = GameObject.FindGameObjectsWithTag("capsule")[0];
        print(innerTube);
        defaultTexture = innerTube.GetComponent<Renderer>().material.mainTexture;
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
        innerTube.GetComponent<Renderer>().material.mainTexture = myNewTexture2D;
    }

    private void OnCollisionExit(Collision collision)
    {
        innerTube.GetComponent<Renderer>().material.mainTexture = defaultTexture;
    }
}
