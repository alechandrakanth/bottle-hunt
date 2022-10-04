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

    public int lives = 3;
    public bool gameOver = false;
  
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        InvokeRepeating("SpawnBottle", startDelay, spawnInterval);
        Debug.Log("Spawned Bottle");
        bottleControllerScript = bottlePrefab.GetComponent<BottleController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     bottleControllerScript.Throw();
        // }

        if (lives == 0)
        {
            gameOver = true;
            CancelInvoke("SpawnBottle");
            PlayerPrefs.Save();
        }
    }

    void SpawnBottle()
    {
        float spawnPosX= Random.Range(-1314f, 70f);
         
       // Vector3(-1314, -402, -48)
       Instantiate(bottlePrefab, new Vector3(spawnPosX, -322, -48), bottlePrefab.transform.rotation);
        

    }

    

}
