using UnityEngine;
using System.Collections;

public class BlockGenerater : MonoBehaviour
{
	public float generateInterval = 3f;
	public GameObject[] blockPrefab;
	public Transform blockParent;

	public CameraSplitCtrl cameraCtrl;

	float currTimeCount = 0f;
	
	// Update is called once per frame
	void Update ()
	{
		// timer
//		if (currTimeCount >= generateInterval) {
//			generateBlock ();
//			currTimeCount -= generateInterval;
//		} else {
//			currTimeCount += Time.deltaTime;
//		}
	}

	public GameObject generateBlock(Material m){
		int index = Random.Range (0, blockPrefab.Length);
		GameObject blockObj = Instantiate (blockPrefab[index]) as GameObject;
		blockObj.transform.SetParent (blockParent);
		blockObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
		blockObj.layer = LayerMask.NameToLayer ("Obstacle" + cameraCtrl.justAddWorldId);
		blockObj.GetComponent<Renderer> ().sharedMaterial = m;
		blockObj.GetComponent<BlockItem> ().Init (cameraCtrl.justAddWorldId);
		return blockObj;
	}
}

