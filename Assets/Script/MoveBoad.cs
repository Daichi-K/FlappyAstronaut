using UnityEngine;
using System.Collections;

public class MoveBoad : MonoBehaviour {

	public float speed = 1;

	void FixedUpdate ( ) {
		GetComponent<Rigidbody2D>( ).velocity =  Vector2.left * speed;
	}

	void OnTriggerExit2D (Collider2D cal) {
		if ( cal.tag == "Destroy") {
			Destroy (this.gameObject);
		}
	}
}
