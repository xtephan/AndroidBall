using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {
	
	private int score = 0;
	public TextMesh ScoreText;
	
	// Use this for initialization
	void Start () {
		
		// Update score based on time
		InvokeRepeating("UpdateScore", 0.05f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Increases the score
	private void UpdateScore() {
		score++;
		ScoreText.text = "Score: " + score.ToString();
	}
	
	//Manage Game Over and save high score
	public void GameOver() {
		
		//save High Score
		if( score > PlayerPrefs.GetInt("highScore") )
			PlayerPrefs.SetInt("highScore",score);
		
		
		//Go to menu
		Application.LoadLevel("menuScene");
	}
	
}
