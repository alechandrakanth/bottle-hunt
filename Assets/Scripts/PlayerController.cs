using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float gravityMod = 1.6f;

    SpawnManager spwnManager;
    
    // Start is called before the first frame update
    void Start()
    {
        // Physics.gravity *= gravityMod;
        spwnManager = GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetMouseButtonDown(0) && spwnManager.gameOver==false)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


                if (Physics.Raycast(ray, out hit))
                {
                    GameObject.Destroy(hit.transform.gameObject);
                    ScoreManager.instance.AddPoint();

                }
            }
        
    }

   
}
