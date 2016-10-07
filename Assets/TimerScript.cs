using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public static float timer = 0;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (UIManegerScript.isStarting && !BoadHitScript.isBoadHitting) {
			timer += Time.deltaTime;
		}
	}
}
