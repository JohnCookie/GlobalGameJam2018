using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerItem : MonoBehaviour
{
	public int worldId = 1;
	List<GameObject> relatiedObstacle = new List<GameObject> ();

	public void Init(int world){
		worldId = world;
	}

	public void addObstacle(GameObject obj){
		relatiedObstacle.Add (obj);
	}

	public void destroyRelatedObstacle(){
		for (int i = 0; i < relatiedObstacle.Count; i++) {
			Destroy (relatiedObstacle [i]);
		}
	}
}

