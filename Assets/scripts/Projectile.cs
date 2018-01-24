using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public Enemy Target;
	public Fighter MyParentFighter;

	public float MySpeed = 1f;


	void Start () {
		Vector3 startPosition = MyParentFighter.transform.position;
		transform.position = startPosition;
	}


	void Update () {
		Vector3 destination = Target.transform.position;

		Vector3 position = transform.position;
		Vector3 P4 = Target.EnemyPosition;
		transform.position = P4;

		Debug.DrawLine (position, destination, Color.red);

		if (P4 == destination) {
			Target.HandleProjectileImpact();
			Destroy (gameObject);
		}
	}

}
