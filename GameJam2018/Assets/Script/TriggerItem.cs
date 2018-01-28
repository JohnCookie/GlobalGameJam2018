using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerItem : MonoBehaviour
{
	public int worldId = 1;
	public int matIndex = 0;
	List<GameObject> relatiedObstacle = new List<GameObject> ();

	public Material[] allColorMaterials;

	public void Init(int world, int materialIndex){
		worldId = world;
		matIndex = materialIndex;
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

