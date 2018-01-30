using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour {

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
		// TODO:   check if onscreen then destroy projectile
		foreach (Enemy enemy in EnemyMgr.inst.AllEnemies) {
			Vector3 toEnemy = enemy.transform.position - transform.position;
			float distance = toEnemy.magnitude;

			if (distance <= .3f) {
				enemy.HandleProjectileImpact ();
				Destroy (gameObject);
			}
		}

		if (transform.position.y > 8) {
			Destroy (gameObject);
		}
	}

}
