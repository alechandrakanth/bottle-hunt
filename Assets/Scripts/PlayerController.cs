using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravityMod = 1;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform);
                GameObject.Destroy(hit.transform.gameObject);
            }
        }
    }

   
}
