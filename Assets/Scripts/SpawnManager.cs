using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public List<GameObject> bottlePrefab; // List of objects(cans) to spawn
    
    

    public int lives = 3; // lives initialized
    public bool gameOver = false; // game over bool 

    private float spawnRate; // Rate of spawning initialized

    public int countDownTime = 3;
    public Text countDownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        // Countdown Coroutine called.
        Debug.Log("Start");

        StartCoroutine(CountdowntoStart());

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
            gameOver = true; // sets game over to true
           // CancelInvoke("SpawnBottle"); Invoke not being used anymore
            PlayerPrefs.Save(); // saves PlayerPrefs for highscore.
            StartCoroutine(CountdowntoEnd());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game Screen");
        }

    }

    

    IEnumerator CountdowntoEnd()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }

    IEnumerator CountdowntoStart() // Countdown Coroutine
    {
        while (countDownTime > 0)
        {
            countDownDisplay.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
        countDownDisplay.text = "SHOOT!";
        StartCoroutine(SpawnBottle()); // Spawning Coroutine

        yield return new WaitForSeconds(1f);
        countDownDisplay.gameObject.SetActive(false);

    }

    IEnumerator SpawnBottle() // Spawning IEnum
    {
        while (!gameOver)
        {
            int index = Random.Range(0, bottlePrefab.Count); //Random index generated
            spawnRate = Random.Range(0.8f, 2.2f); // Random Spawn rate generated
            yield return new WaitForSeconds(spawnRate); // wait for spawning seconds

            float spawnPosX = Random.Range(-36,36); // Random Spawn X Coordinate

            // Vector3(-1314, -402, -48) // previous reference 
            Instantiate(bottlePrefab[index], new Vector3(spawnPosX, -20, 32), bottlePrefab[index].transform.rotation); // Spawn Cans
        }
        
        

    }

    

}
