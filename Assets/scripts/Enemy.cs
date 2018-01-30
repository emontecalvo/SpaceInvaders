using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Vector3 EnemyPosition;

	public float LeftWall = -8.5f;
	public float RightWall = 8.5f;

	public bool GoingLeft = false;


	void Start () {
		EnemyMgr.inst.Register (this);
		EnemyPosition = transform.position;
	}

	void Update () {
		EnemyMovement ();

	}

	void EnemyMovement() {
		Vector3 myPosition = transform.position;

		if (myPosition.x < RightWall && !GoingLeft) {
			myPosition.x += .1f;
		} else if (myPosition.x > LeftWall && GoingLeft) {
			myPosition.x -= .1f;
		} 

		transform.position = myPosition;
	}


	public void HandleProjectileImpact() {
		Destroy (gameObject);
//		CurrentHitPoints -= 1;
//		if (CurrentHitPoints == 0) {
//			Destroy (gameObject);
//		}
	}

	void OnDestroy() {
		if (EnemyMgr.inst != null) {
			EnemyMgr.inst.Unregister (this);
		}
	}
}
