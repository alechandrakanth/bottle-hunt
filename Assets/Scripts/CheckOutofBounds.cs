using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutofBounds : MonoBehaviour
{
    SpawnManager spwnManager;
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
        if (other.CompareTag("Bottle")&&spwnManager.gameOver==false)
        {
            Destroy(other.gameObject);
            ScoreManager.instance.TakeLife();
            
        }
    }
}
