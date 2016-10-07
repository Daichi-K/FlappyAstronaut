using UnityEngine;
using System.Collections;

public class MoveTiling : MonoBehaviour {

	[SerializeField]
	float speed = 1;
	float current;

	// Update is called once per frame
	void Update () {
		current += Time.deltaTime * speed;

		GetComponent<MeshRenderer> ()
			.material
			.SetTextureOffset ("_MainTex",new Vector2( current, 0));
	}
}
