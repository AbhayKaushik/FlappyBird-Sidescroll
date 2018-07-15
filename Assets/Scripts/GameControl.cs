using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject GameOverText;
    public Text ScoreText;
    public bool GameOver = false;
    public float ScrollSpeed = 1.5f;
    private int Score = 0;

	// Used for setting up our game control before the start of the game
	void Awake () {

        if (instance == null)
        {
            instance = this;

        }else if (instance != null)
        {
            Destroy(GameOverText);
        }
	}

    // Update is called once per frame
    void Update() {

        if (GameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
            
	}

    public void BirdScore()
    {
        if (GameOver)
        {
            return;
        }
        Score++ ;
        ScoreText.text = "Score: " + Score.ToString ();
    }

    public void birdDied () {

        GameOverText.SetActive(true);
        GameOver = true;

    }
}
