using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMyHeading : MonoBehaviour {

    public Vector3 Heading;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Heading = transform.rotation.eulerAngles;	
	}
}
