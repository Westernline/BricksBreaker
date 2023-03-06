using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject BallSpawner;
    //private DottedLine dl;
    private void Start()
    {
        //dl = FindObjectOfType<DottedLine>();
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
        BallSpawner.SetActive(false);
    }
}
