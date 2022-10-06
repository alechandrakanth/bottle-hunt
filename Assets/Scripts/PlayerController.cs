using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float gravityMod = 1.6f;

    SpawnManager spwnManager;
    public List<AudioClip> gunShotSounds;

    private AudioSource audioGun;

   
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
        
        
            if (Input.GetMouseButtonDown(0) && spwnManager.gameOver==false)
            {
                int index = Random.Range(0, gunShotSounds.Count);
                audioGun.clip  = gunShotSounds[index];
                audioGun.Play();
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
