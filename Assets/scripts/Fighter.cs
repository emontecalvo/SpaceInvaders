﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fighter : MonoBehaviour {

	private static Fighter _inst = null;

	public static Fighter inst {
		get {
			if (_inst == null) {
				_inst = FindObjectOfType<Fighter> ();
			}
			return _inst;
		}
	}

	public GameObject ProjectilePrefab;

	public KeyCode LeftKey;
	public KeyCode RightKey;

	void Start () {
		
	}
	

	void Update () {
		MovementLogic ();
		FiringLogic ();
		
	}

	void MovementLogic () {
		Vector3 speed = Vector3.zero;

		if (Input.GetKey (LeftKey)) {
			speed.x = -9;
		}
		
		if (Input.GetKey (RightKey)) {
			speed.x = 9;
		}

		transform.position = transform.position + speed * Time.deltaTime;
	}

	void FiringLogic() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject projectile = (GameObject)Instantiate (ProjectilePrefab);
			projectile.transform.position = transform.position;
		}
	}






}
