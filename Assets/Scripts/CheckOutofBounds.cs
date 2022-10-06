using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutofBounds : MonoBehaviour
{
    SpawnManager spwnManager; // reference to spawn manager
    // Start is called before the first frame update
    void Start()
    {
        spwnManager = GameObject.Find("GameManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (spwnManager.gameOver==false)
       {
            ScoreManager.instance.TakeLife(); // Reduces Life in Spawn Manager
       }
    }
}
