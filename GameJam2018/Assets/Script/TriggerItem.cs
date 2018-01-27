using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerItem : MonoBehaviour
{
	List<GameObject> relatiedObstacle = new List<GameObject> ();

	public void addObstacle(GameObject obj){
		relatiedObstacle.Add (obj);
	}

	public void destroyRelatedObstacle(){
		for (int i = 0; i < relatiedObstacle.Count; i++) {
			Destroy (relatiedObstacle [i]);
		}
	}
}

