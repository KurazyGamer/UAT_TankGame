using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float rateOfFire;
    public GameObject Bullet;
    public Transform bulletSpawnPoint;
    public float fireForce;
    public float lifeSpan;


    // Start is called before the first frame update
    void Start()
    {
        // makes sure that its rate of fire instead of fire rate
        rateOfFire = 1 / rateOfFire;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // function for shooting
    public void Shoot() 
    {
        
        // instantiates a new bullet of type bullet with the position of the spawn transform with no change in rotation
        GameObject newBullet = Instantiate(Bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as GameObject;
        Rigidbody rb = newBullet.GetComponent<Rigidbody>();
        if (rb != null )
        {
            rb.AddForce(bulletSpawnPoint.forward * fireForce);
        }

        Destroy(newBullet, lifeSpan);
    }
}
