using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour {

	public GameObject FireImg;
	public float TimeUntilNextFrame;
	public float TimeBetweenFrames = 10000.0f;

	void Start() {
		FireImg.SetActive (true);
	}

	void Update () {
		MovementLogic ();
		IsEnemyHit ();
	}

	void MovementLogic () {
		Vector3 speed = Vector3.zero;

		speed.y += 10;

		transform.position = transform.position + speed * Time.deltaTime;
	}

	void IsEnemyHit() {
		foreach (Enemy enemy in EnemyMgr.inst.AllEnemies) {
			Vector3 toEnemy = enemy.transform.position - transform.position;
			float distance = toEnemy.magnitude;

			if (distance <= .3f) {
				enemy.HandleProjectileImpact ();
				Destroy (gameObject);
			}

			TimeUntilNextFrame -= Time.deltaTime;

			if (TimeUntilNextFrame <= 0) {
				TimeUntilNextFrame = TimeBetweenFrames;
				FireImg.SetActive (false);
				Debug.Log ("here");
			} else {
				FireImg.SetActive (true);
			}
		}

		if (transform.position.y > 8) {
			Destroy (gameObject);
		}
	}

}
