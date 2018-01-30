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

	void Update() {
		CheckPosition ();
	}

	void CheckPosition() {
		foreach (Enemy enemy in AllEnemies) {
			if (enemy.transform.position.x > enemy.RightWall && !enemy.GoingLeft) {
				foreach (Enemy enemySub in AllEnemies) {
					Vector3 sub = enemySub.transform.position;
					sub.y -= 1f;
					enemySub.transform.position = sub;
					enemySub.GoingLeft = true;
				}
			} else if (enemy.transform.position.x <= enemy.LeftWall && enemy.GoingLeft) {
				foreach (Enemy enemySub2 in AllEnemies) {
					Vector3 sub2 = enemySub2.transform.position;
					sub2.y -= 1f;
					enemySub2.transform.position = sub2;
					enemySub2.GoingLeft = false;
				}
			}
		}
	}


}
