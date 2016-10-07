using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool isJumpRequest;
	public float power;
	float bardAngle = 0;

	[SerializeField]
	private bool isDead = false;
	public bool IsDead {get{ return isDead;}}

	[SerializeField]
	private bool isStarted = false;

	void Update ( ) {
		transform.rotation = Quaternion.Euler (0, 0, bardAngle);

		//ボードにＨＩＴ
		if (BoadHitScript.isBoadHitting) {
			bardAngle += 8.0f;
			if (bardAngle >= 270) {
				bardAngle = 270;
			}
		} else {
			if (UIManegerScript.isStarting) {
				if (Input.GetMouseButtonDown (0)) {
					isJumpRequest = true;
					bardAngle = 25;
				}
			
				bardAngle -= 1.0f;
				if (bardAngle <= -60) {
					bardAngle = -60;
				}
			} else {
				Time.timeScale = 0;
			}
		}
	}
	public void FixedUpdate ( ) {
		if (isJumpRequest) {
			isJumpRequest = false;
			GetComponent<Rigidbody2D> ().velocity = Vector2.up * power;
		}
	}

	public void Init( ) {
		GetComponent<CircleCollider2D> ().enabled = true;
		transform.position = new Vector3 (0, 0, 0);
		isStarted = false;
		GetComponent<Rigidbody2D> ().isKinematic = true;
	}

	public void PlayerJump( ) {
		if (!isStarted) {
			isStarted = true;
			GetComponent<Rigidbody2D> ().isKinematic = false;
		} else {
			if (!isDead) {
				var playerPositionY = transform.position.y;
				if (playerPositionY < 5) {
					GetComponent<Rigidbody2D> ().velocity = Vector2.up * power;
				}
			} else {
				GetComponent<CircleCollider2D> ().enabled = false;;
			}
		}
	}

}
