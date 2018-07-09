using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour {

    public GameObject Projectile;
    public int SpeedMultiplier;

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
	}

    void Fire()
    {
        GameObject projectileInstance = Instantiate(Projectile, transform.position, transform.rotation);
        //projectileInstance.transform.Rotate(transform.rotation.);
        projectileInstance.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * SpeedMultiplier, ForceMode.VelocityChange);
    }
}
