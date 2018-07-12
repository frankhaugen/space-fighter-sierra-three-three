using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    DeadZone deadZone = new DeadZone();
    public float HorizontalInput;
    public float VerticalInput;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        HorizontalInput = deadZone.CheckIfInDeadZone(Input.GetAxis("Horizontal"));
        VerticalInput = deadZone.CheckIfInDeadZone(Input.GetAxis("Vertical"));
    }

    void ChangeRotation()
    {
        transform.Rotate(Vector3.up * TurnSpeedMultiplyer * Time.deltaTime * -1);
    }
}
