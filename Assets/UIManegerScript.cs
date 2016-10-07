using UnityEngine;
using System.Collections;

public class UIManegerScript : MonoBehaviour {

	public GameObject startCanvas;
	public GameObject gameCanvas;
	public GameObject resultCanvas;

	public GameObject boadController;

	public GameObject pouseScreen;

	public static bool isStarting = false;
	public static bool isgameOver = false;

	bool isPousing = false;

	float timer = 0;

	// Use this for initialization
	void Start () {
		startCanvas.SetActive (true);
		gameCanvas.SetActive (false);
		resultCanvas.SetActive (false);
		boadController.SetActive (false);

		isStarting = false;
		isgameOver = false;

		BoadHitScript.isBoadHitting = false;
	}
	
	// Update is called once per frame
	void Update () {
		//ボタンでスタート
		if (Input.GetMouseButtonDown (0) && isStarting == false ) {
			isStarting = true;
			Time.timeScale = 1;
		}

		//ゲームオーバー
		if (BoadHitScript.isBoadHitting) {
			timer += Time.deltaTime;
		}
		if (timer >= 2.0f) {
			isStarting = false;
			isgameOver = true;
		}

		//UI管理
		if( isStarting ) {
			startCanvas.SetActive (false);
			gameCanvas.SetActive (true);

			boadController.SetActive (true);
		}
		if (isgameOver) {
			gameCanvas.SetActive (false);
			resultCanvas.SetActive (true);

			boadController.SetActive (false);
		}
	}

	public void PouseButton( ) {
		if (isPousing) {
			isPousing = false;
			Time.timeScale = 1;
			pouseScreen.SetActive (false);
		} else {
			isPousing = true;
			Time.timeScale = 0;
			pouseScreen.SetActive (true);
		}
	}
}
