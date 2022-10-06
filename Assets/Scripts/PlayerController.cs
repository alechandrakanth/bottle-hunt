using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float gravityMod = 1.6f; // Changed gravity in preferences to avoid compounding on restart

    SpawnManager spwnManager; // Spawn Manager Reference

    public List<AudioClip> gunShotSounds; // Audio Clips List

    private AudioSource audioGun; //Audio Source reference

    public ParticleSystem explodePrefab;
   
    // Start is called before the first frame update
    void Start()
    {
        audioGun = GetComponent<AudioSource>();

        // Physics.gravity *= gravityMod;

        spwnManager = GetComponent<SpawnManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetMouseButtonDown(0) && spwnManager.gameOver==false) // check Mouse input and game over
            {
                int index = Random.Range(0, gunShotSounds.Count); // random index for audio

                audioGun.clip  = gunShotSounds[index]; // set audio

                audioGun.Play(); // play audio

                RaycastHit hit; // Initialize Raycast

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Get mousePos and draw ray


                if (Physics.Raycast(ray, out hit)) // check hit object
                {
                
                GameObject.Destroy(hit.transform.gameObject); // destroy hit object
                ParticleSystem explosion=Instantiate(explodePrefab, hit.transform.position, hit.transform.rotation); // Instantiate Particle
                explosion.Play(); // play Particle animation
                ScoreManager.instance.AddPoint(); // Call add point in score manager instance
                 
                }
            }
        
    }

   
}
