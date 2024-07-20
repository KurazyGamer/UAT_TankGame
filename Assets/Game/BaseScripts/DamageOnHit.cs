using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageDone;
    public GameObject impactParticle;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        // grabs the pawn of the object that it collided with
        BasePawn otherPawn = other.gameObject.GetComponent<BasePawn>();

        // checks if its null
        if (otherPawn == null)
        {
            GameObject newimpactParticle = Instantiate(impactParticle, this.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(newimpactParticle, 2);
        } else {
            //grabs the health component
            HealthComp otherHealth = other.GetComponent<HealthComp>();
            //checks if its null and takes damage
            if (otherHealth != null)
            {
                otherHealth.TakeDamage(damageDone, otherPawn);
            }

            // destorys the bullet object and creates a impact particle effect for 2 seconds then destorys that particle effect.
            Destroy(this.gameObject, 2);
            GameObject newimpactParticle = Instantiate(impactParticle, this.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(newimpactParticle, 2);
        }
        
        
    }
}
