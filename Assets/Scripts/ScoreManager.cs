using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText; // Score UI
    public Text highScoreText; // High Score UI
    public Text livesText; // Lives UI
    public Text gameOverText; // Game Over UI
    public Image gameOverBox; // Game Over Box

    int score = 0; // score variable
    int highscore = 0; // highscore variable
    int lives; // lives variable

    SpawnManager spwnManager;
    private void Awake()
    {
        instance = this; // creates a static instance of the game object to be accessible by other scripts.
    }
    // Start is called before the first frame update
    void Start()
    {
        spwnManager = GetComponent<SpawnManager>(); // reference to spawn manager

        // initializing values

        lives = spwnManager.lives;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "Highscore: " + highscore.ToString();
        livesText.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            // creates game over screen
            gameOverText.gameObject.SetActive(true);
            gameOverBox.gameObject.SetActive(true);
        }
    }

    public void AddPoint()
    {

        // Adds score  
        score += 100;
        scoreText.text = "Score: " + score.ToString();

        // Checks highscore
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score); // updates highscore in PlayerPrefs
        highScoreText.text = "Highscore: " + highscore.ToString();
        Debug.Log(score);


    }
    public void TakeLife()
    {
        // if (lives > 0)
        // {
        // reduces life on Miss
        // if statement removed because it was redundant.
        lives--;
        spwnManager.lives = lives;
        livesText.text = "Lives: " + lives.ToString();
        Debug.Log(lives);
        // }
    }
}
