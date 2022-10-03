using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bottlePrefab;
    public BottleController bottleControllerScript;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnBottle", startDelay, spawnInterval);
        bottleControllerScript = bottlePrefab.GetComponent<BottleController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     bottleControllerScript.Throw();
       // }
    }

    void SpawnBottle()
    {
        float spawnPosX= Random.Range(-1314f, 70f);
         
       // Vector3(-1314, -402, -48)
       Instantiate(bottlePrefab, new Vector3(spawnPosX, -228, -48), bottlePrefab.transform.rotation);
       

    }
}
