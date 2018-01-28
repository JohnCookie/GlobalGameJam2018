using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterGenerator : MonoBehaviour
{
	public float generateInterval = 3f;
	public GameObject monsterPrefab;
	public Transform monsterRoot;
	public PlayerCtrl player;
	public CameraSplitCtrl cameraCtrl;

	float currTimeCount = 0f;

	public Material[] allColorMaterials;

	Dictionary<int, List<GameObject>> worldToMonster = new Dictionary<int, List<GameObject>>();

	// Update is called once per frame
	void Update ()
	{
		// timer
//		if (currTimeCount >= generateInterval) {
//			generateMonster ();
//			currTimeCount -= generateInterval;
//		} else {
//			currTimeCount += Time.deltaTime;
//		}
	}

	public void generateMonster(int materialIndex){
		int num = Random.Range (1, 3);
		for (int k = 0; k < num; k++) {
			GameObject monsterObj = Instantiate (monsterPrefab) as GameObject;
			monsterObj.transform.SetParent (monsterRoot);
			monsterObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
			monsterObj.GetComponent<Renderer> ().material = allColorMaterials [materialIndex];
			monsterObj.layer = LayerMask.NameToLayer ("Monster1");
			monsterObj.GetComponent<SimpleMonster> ().Init (player, cameraCtrl.justAddWorldId, materialIndex);

			if (worldToMonster.ContainsKey (materialIndex)) {
				worldToMonster [materialIndex].Add (monsterObj);
			} else {
				List<GameObject> list = new List<GameObject> ();
				list.Add (monsterObj);
				worldToMonster.Add (materialIndex, list);
			}
		}
	}

	public void removeMonsterByWorld(int materialId){
		for (int i = 0; i < worldToMonster [materialId].Count; i++) {
			Destroy (worldToMonster [materialId][i]);
		}
		worldToMonster.Remove (materialId);
	}
}

