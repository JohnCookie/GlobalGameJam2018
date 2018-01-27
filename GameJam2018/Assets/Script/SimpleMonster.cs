using UnityEngine;
using System.Collections;

public class SimpleMonster : MonoBehaviour
{
	PlayerCtrl target;
	public float spd = 10f;
	int worldId = 1;

	void Update(){
		Vector3 dir = target.transform.position - transform.position;
		transform.position += dir.normalized * spd * Time.deltaTime;
	}

	public void Init(PlayerCtrl p, int world){
		target = p;
		worldId = world;
	}
}

