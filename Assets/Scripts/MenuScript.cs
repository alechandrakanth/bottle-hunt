using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        // goes forward by one build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HowToPlay()
    {
        // goes to How to Play screen
        SceneManager.LoadScene("How To Play");
    }

    public void Back()
    {
        // goes back to the Main Menu
        SceneManager.LoadScene("Start Menu");
    }
}
