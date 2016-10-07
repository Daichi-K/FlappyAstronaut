using UnityEngine;
using System.Collections;

public class SceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void TitleScene( ) {
		Application.LoadLevel("Title");
	}

	public void GameScene( ) {
		Application.LoadLevel("Game");
	}

	public void RankingScene( ) {
		Application.LoadLevel("Ranking");
	}
}
