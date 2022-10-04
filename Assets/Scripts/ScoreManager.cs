using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScoreText;
    public Text livesText;

    int score = 0;
    int highscore = 0;
    int lives;
    SpawnManager spwnManager;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spwnManager = GetComponent<SpawnManager>();

        lives = spwnManager.lives;
        highscore=PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "Highscore: " + highscore.ToString();
        livesText.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        highScoreText.text = "Highscore: " + highscore.ToString();
        Debug.Log(score);

        
    }
    public void TakeLife()
    {
       // if (lives > 0)
       // {
            lives--;
            spwnManager.lives = lives;
            livesText.text = "Lives: " + lives.ToString();
            Debug.Log(lives);
       // }
    }
}
