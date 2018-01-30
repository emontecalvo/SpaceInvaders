using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMgr : MonoBehaviour {

	private static EnemyMgr _inst = null;

	public static EnemyMgr inst {
		get {
			if (_inst == null) {
				_inst = FindObjectOfType<EnemyMgr> ();
			}
			return _inst;
		}
	}

	public List <Enemy> AllEnemies = new List<Enemy> ();

	public void Register (Enemy enemy) {

		AllEnemies.Add (enemy);

	}

	public void Unregister (Enemy enemy) {
		AllEnemies.Remove (enemy);
	}


}
