using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Vector3 EnemyPosition;


	void Start () {
		EnemyMgr.inst.Register (this);
		EnemyPosition = transform.position;
	}

	void Update () {

	}


	public void HandleProjectileImpact() {
		Debug.Log ("HANDLE IMPACT CALLED");
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
