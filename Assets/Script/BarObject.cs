using UnityEngine;
using System.Collections;

public class BarObject : MonoBehaviour {

	float nextSpawnTime = 0;
	int rand = 0;

	//障害物
	public GameObject stage1Object;
	public GameObject stage2Object;
	public GameObject stage3Object;
	public GameObject stage4Object;

	//障害物間隔
	public float stage1Interval = 3;
	public float stage2Interval = 2;
	public float stage3Interval = 2;
	public float stage4Interval = 2;
	public float stage5Interval = 2.5f;

	//ステージの時間
	public float stage1Time = 20;
	public float stage2Time = 40;
	public float stage3Time = 60;
	public float stage4Time = 80;

	void Stage1Instantate ( ) {
		GameObject obj = (GameObject)GameObject.Instantiate (stage1Object);
		obj.transform.parent = transform;
		float y = Random.Range (-2.5f, 2.5f);
		obj.transform.localPosition = new Vector3 (10, y, 0);
	}

	void Stage2Instantate ( ) {
		GameObject obj = (GameObject)GameObject.Instantiate (stage2Object);
		obj.transform.parent = transform;
		float y = Random.Range (-4.5f, 4.5f);
		obj.transform.localPosition = new Vector3 (10, y, 0);
	}

	void Stage3Instantate ( ) {
		GameObject obj = (GameObject)GameObject.Instantiate (stage3Object);
		obj.transform.parent = transform;
		float y = Random.Range (-4.5f, 4.5f);
		obj.transform.localPosition = new Vector3 (5, y, 0);
	}

	void Stage4Instantate ( ) {
		GameObject obj = (GameObject)GameObject.Instantiate (stage4Object);
		obj.transform.parent = transform;
		float y = Random.Range (-4.5f, 4.5f);
		obj.transform.localPosition = new Vector3 (10, y, 0);
	}

	void Update(){
		if( nextSpawnTime < Time.timeSinceLevelLoad)
		{
			if (Time.timeSinceLevelLoad <= stage1Time) {
				nextSpawnTime = Time.timeSinceLevelLoad + stage1Interval;
				Stage1Instantate ();
			} else if (Time.timeSinceLevelLoad > stage1Time && Time.timeSinceLevelLoad <= stage2Time ) {
				nextSpawnTime = Time.timeSinceLevelLoad + stage2Interval;
				Stage2Instantate ();
			} else if (Time.timeSinceLevelLoad > stage2Time && Time.timeSinceLevelLoad <= stage3Time ) {
				nextSpawnTime = Time.timeSinceLevelLoad + stage3Interval;
				Stage3Instantate ();
			} else if (Time.timeSinceLevelLoad > stage3Time + 2.0f && Time.timeSinceLevelLoad <= stage4Time ) {
				nextSpawnTime = Time.timeSinceLevelLoad + stage4Interval;
				Stage4Instantate ();
			} else if (Time.timeSinceLevelLoad > stage4Time ) {
				nextSpawnTime = Time.timeSinceLevelLoad + stage5Interval;

				rand = Random.Range (0, 4);
				if (rand == 0) {
					Stage1Instantate ();
				} else if (rand == 1) {
					Stage2Instantate ();
				} else if (rand == 2) {
					Stage3Instantate ();
				} else if (rand == 3) {
					Stage4Instantate ();
				}
			}
		}
	}
}