using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour {

    public ParticleSystem blasterParent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
        {
            ParticleSystem blaster = new ParticleSystem();

            blaster = blasterParent;
        }
	}
}
