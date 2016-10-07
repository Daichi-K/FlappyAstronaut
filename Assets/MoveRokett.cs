using UnityEngine;
using System.Collections;

public class MoveRokett : MonoBehaviour {

	public float farstSpeed = 1;
	public float secondSpeed = 1;

	public float farstTimeEnd = 1.0f;
	public float secomdTimeStart = 1.0f;

	float timer = 0;

	void FixedUpdate ( ) {
		timer += Time.deltaTime;

		if (timer <= farstTimeEnd) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.left * farstSpeed;
		}
		if (timer >= secomdTimeStart) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.left * secondSpeed;
		}
	}

	void OnTriggerExit2D (Collider2D cal) {
		if ( cal.tag == "Destroy") {
			Destroy (this.gameObject);
		}
	}
}
