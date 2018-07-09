using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour {
    
    public float Speed;
    public Vector3 Speeds;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Speed = GetComponent<Rigidbody>().velocity.magnitude;
        Speeds = GetComponent<Rigidbody>().velocity;
    }
}
