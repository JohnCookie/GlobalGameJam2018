using UnityEngine;
using System.Collections;

public class BlockGenerater : MonoBehaviour
{
	public float generateInterval = 3f;
	public GameObject blockPrefab;
	public Transform blockParent;

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
		GameObject blockObj = Instantiate (blockPrefab) as GameObject;
		blockObj.transform.SetParent (blockParent);
		blockObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
	}
}

