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
  //  public GameObject bottlePrefabInstance = GameObject.Instantiate<GameObject>(bottlePrefab);
    // Start is called before the first frame update
    void Start()
    {
        //bottleControllerScript = bottlePrefab.GetComponent<BottleController>();
        InvokeRepeating("SpawnBottle", startDelay, spawnInterval);
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
        bottleControllerScript.Throw();
        Instantiate(bottlePrefab, new Vector3(-1097, -228, -48), bottlePrefab.transform.rotation);
    }
}
