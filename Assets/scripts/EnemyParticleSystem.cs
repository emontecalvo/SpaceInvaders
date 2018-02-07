using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticleSystem : MonoBehaviour {


//	float TimeRemaining = 1.0f;
//
//	void Start () {
//		
//	}
//	
//
//	void Update () {
//		TimeRemaining -= Time.deltaTime;
//		if (TimeRemaining <= 0) {
//			Destroy (gameObject);
//		}
//		
//	}



//	float Lifespan = 1.0f;
//
//	void Update() {
//		Lifespan -= 0.01f;
//		if (Lifespan <= 0) {
//			Destroy (gameObject);
//		}
//		
//	}


	float FinishTime;
	float LifeSpan = 1.0f;

	void Start() {
		float currentTime = Time.time;
		FinishTime = currentTime + LifeSpan;
		Debug.Log ("FinishTime:  " + FinishTime);
	}

	void Update() {
		float currentTime = Time.time;
		if (currentTime >= FinishTime) {
			Destroy (gameObject);
		}
		Debug.Log ("CurrentTime:  " + currentTime + "   FinishTime:  " + FinishTime);
	}
}
