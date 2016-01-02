using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject projectile;

    public float force = 500;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //GameObject o = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            GameObject o = ObjectPool.instance.GetObject("Ball", transform.position, Quaternion.identity) as GameObject;
            Rigidbody r = o.GetComponent<Rigidbody>();
            r.AddForce(0, 0, force);
        }
	}
}
