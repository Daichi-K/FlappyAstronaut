using UnityEngine;
using System.Collections;

public class BackGroundScript : MonoBehaviour {

	public float speed = 1;

	private float y = 0;
	private float z = 0;

	void FixedUpdate ( ) {
		GetComponent<Rigidbody2D>( ).velocity =  Vector2.left * speed;
	}

	void OnTriggerExit2D (Collider2D cal) {
		if ( cal.tag == "Destroy") {
			y = this.transform.localPosition.y;
			z = this.transform.localPosition.z;
			this.transform.localPosition = new Vector3 (7, y, z);
		}
	}
}
