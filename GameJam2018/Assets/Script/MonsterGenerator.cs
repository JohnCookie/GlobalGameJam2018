using UnityEngine;
using System.Collections;

public class MonsterGenerator : MonoBehaviour
{
	public float generateInterval = 3f;
	public GameObject monsterPrefab;
	public Transform monsterRoot;
	public PlayerCtrl player;

	float currTimeCount = 0f;

	// Update is called once per frame
	void Update ()
	{
		// timer
		if (currTimeCount >= generateInterval) {
			generateBlock ();
			currTimeCount -= generateInterval;
		} else {
			currTimeCount += Time.deltaTime;
		}
	}

	void generateBlock(){
		GameObject monsterObj = Instantiate (monsterPrefab) as GameObject;
		monsterObj.transform.SetParent (monsterRoot);
		monsterObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
		monsterObj.GetComponent<SimpleMonster> ().Init (player);
	}
}

