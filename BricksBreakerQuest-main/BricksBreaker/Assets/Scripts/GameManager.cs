using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject ballSpawner;
    public GameObject MainMenuPanel;
    public GameObject Canvas;
    public GameObject GameOverPanel;
    public GameObject SpeedUpParent;
    

    public GameObject winnerPanel;

    int score = 0;

    bool winner = false;
    

    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if(score >= 5)
        {
            winner = true;

            Winner();
        }*/

		
	}

    public void SpeedUpTime()
    {
        Time.timeScale = 2.6f;
        SpeedUpParent.SetActive(true);
        
    }
        public void SpeedUpTimeoff()
    {

        Time.timeScale = 1.0f;
        
    }


    public void InrementScore()
    {
        if (!winner)
        {
            score++;
            scoreText.text = score.ToString();

        }

        //print(score);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Target")
        {
            GameOver();
            
        }
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        ballSpawner.SetActive(false);
        BallSpawner.BallCount=10;
    }



    public void Winner()
    {
        winnerPanel.SetActive(true);
        ballSpawner.SetActive(false);

    }
    public void NextLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
    }

    public void BackToMenu()
    {
        MainMenuPanel.SetActive(true);
        Canvas.SetActive(false);
    }
    public void NextLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1.0f;
    }
    public void NextLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void NextLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void NextLevel5()
    {
        SceneManager.LoadScene("Level5");
    }


}
