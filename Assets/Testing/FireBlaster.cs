using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour {

    public GameObject Projectile;
    public int SpeedMultiplier;
    public bool RapidFire = false;
    public float CooldownPeriod = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        if (Input.GetButton("Fire1") && RapidFire)
        {
            Fire();
        }
	}

    void Fire()
    {
        GameObject projectileInstance = Instantiate(Projectile, transform.position, transform.rotation);
        projectileInstance.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * SpeedMultiplier, ForceMode.VelocityChange);
    }
}
