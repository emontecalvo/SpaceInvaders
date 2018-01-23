using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


	void Start () {
		EnemyMgr.inst.Register (this);
	}

	void Update () {

	}
}
