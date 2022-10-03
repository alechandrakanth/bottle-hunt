using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    private Rigidbody rb;
    public float forceValue=20f;
    

    private Vector3 forceToAdd;
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
        forceToAdd = new Vector3(0.35f, 1, 0);
        rb.AddForce(forceToAdd * forceValue, ForceMode.Impulse);
    }
}
