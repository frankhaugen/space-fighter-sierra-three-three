using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMoveScript : MonoBehaviour {

    public float TurnSpeedMultiplyer = 10.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.W)) { GetComponent<Rigidbody>().AddForce(transform.forward); }
            if (Input.GetKey(KeyCode.S)) { GetComponent<Rigidbody>().AddForce(transform.forward * -1); }
            if (Input.GetKey(KeyCode.A)) { transform.Rotate(Vector3.up * TurnSpeedMultiplyer * Time.deltaTime * -1); }
            if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up * TurnSpeedMultiplyer * Time.deltaTime); }
        }
		
	}
}
