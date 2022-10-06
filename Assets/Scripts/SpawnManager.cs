using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> bottlePrefab;
    
    

    public int lives = 3;
    public bool gameOver = false;

    private float spawnRate;
  
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Start");
        StartCoroutine(SpawnBottle());
        Debug.Log("Spawned Bottle");
        
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

    IEnumerator SpawnBottle()
    {
        while (!gameOver)
        {
            int index = Random.Range(0, bottlePrefab.Count);
            spawnRate = Random.Range(0.8f, 2.2f);
            yield return new WaitForSeconds(spawnRate);

            float spawnPosX = Random.Range(-36,36);

            // Vector3(-1314, -402, -48)
            Instantiate(bottlePrefab[index], new Vector3(spawnPosX, -20, 32), bottlePrefab[index].transform.rotation);
        }
        
        

    }

    

}
