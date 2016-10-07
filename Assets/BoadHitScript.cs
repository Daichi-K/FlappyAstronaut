using UnityEngine;
using System.Collections;

public class BoadHitScript : MonoBehaviour {

	public static bool isBoadHitting;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D cal){
		if (cal.tag == "Player") {
			isBoadHitting = true;
		}
	}
}
