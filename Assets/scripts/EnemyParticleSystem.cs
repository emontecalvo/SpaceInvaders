using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticleSystem : MonoBehaviour {

	float TimeRemaining = 1.0f;

	void Start () {
		
	}
	

	void Update () {
		TimeRemaining -= Time.deltaTime;
		if (TimeRemaining <= 0) {
			Destroy (gameObject);
		}
		
	}
}
