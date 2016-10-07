using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	const string HIGH_SCORE_KEY = "highScore";

	public Text scoreText;
	public Text highScoreText;

	private float score = 0;
	private float highScore = 0;

	// Use this for initialization
	void Start () {
		scoreText.text = "Time:0";
		highScoreText.text = "HighScore:0";
		score = 0;
		highScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score = TimerScript.timer;

		highScore = PlayerPrefs.GetFloat(HIGH_SCORE_KEY, -1);

		//ハイスコア代入
		if (score > highScore) {
			SaveHighScore (score);
		}

		//テキストに文字入力
		scoreText.text = "Time:" + score.ToString("f1");
		highScoreText.text = "HighScore:" + highScore.ToString("f1");
	}

	void SaveHighScore(float score){
		PlayerPrefs.SetFloat(HIGH_SCORE_KEY, score);
		PlayerPrefs.Save();
	}
}
