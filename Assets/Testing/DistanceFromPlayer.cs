using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFromPlayer : MonoBehaviour {

    private GameObject Player;
    public float Distance;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Distance = Vector3.Distance(Player.transform.position, transform.position);
    }
}
