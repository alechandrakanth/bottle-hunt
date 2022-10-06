using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    private Rigidbody rb;
    public float forceValue=20f;

    public float torqueValue = 5f;

    private Vector3 forceToAdd;

   public ParticleSystem destroyParticle;

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
        float vectorX = Random.Range(0.35f, 0.5f);
        float vectorY = Random.Range(0.6f, 1.0f);

        if (transform.position.x < -0)
        {
            forceToAdd = new Vector3(vectorX, vectorY, 0);
        }
        else
        {
            forceToAdd = new Vector3(-vectorX, vectorY, 0);
        }
        
        rb.AddForce(forceToAdd * forceValue, ForceMode.Impulse);
        rb.AddTorque(Random.Range(-torqueValue, torqueValue), Random.Range(-torqueValue, torqueValue), Random.Range(-torqueValue, torqueValue), ForceMode.Impulse);

    }

    



}
