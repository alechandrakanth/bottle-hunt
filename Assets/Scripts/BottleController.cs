using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    private Rigidbody rb; // rigidbody reference
    public float forceValue=20f; //  force value to act on object

    public float torqueValue = 5f; // torque value to act on object

    private Vector3 forceToAdd; // Initialize vector for throwing

   public ParticleSystem destroyParticle; // Particle system (not figured out yet)

    // Start is called before the first frame update
    void Start()
    {
        // declaration
        rb = GetComponent<Rigidbody>();
        
        Throw();
        // throws object on instantiate

      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Throw()
    {
        float vectorX = Random.Range(0.35f, 0.5f); // Random X Vector Coordinate
        float vectorY = Random.Range(0.6f, 1.0f);  // Random Y Vector Coordinate

        if (transform.position.x < -0) // Check if left side of screen
        {
            forceToAdd = new Vector3(vectorX, vectorY, 0); // Throw towards top right
        }
        else
        {
            forceToAdd = new Vector3(-vectorX, vectorY, 0); // Throw towards top left
        }
        
        rb.AddForce(forceToAdd * forceValue, ForceMode.Impulse); // Add Force Impulse
        rb.AddTorque(Random.Range(-torqueValue, torqueValue), Random.Range(-torqueValue, torqueValue), Random.Range(-torqueValue, torqueValue), ForceMode.Impulse);

        // Add Torque Impulse
    }

    



}
