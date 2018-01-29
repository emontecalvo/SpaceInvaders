using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour {

	void Update () {
		MovementLogic ();
	}

	void MovementLogic () {
		Vector3 speed = Vector3.zero;

		speed.y += 10;

		transform.position = transform.position + speed * Time.deltaTime;
	}

}
