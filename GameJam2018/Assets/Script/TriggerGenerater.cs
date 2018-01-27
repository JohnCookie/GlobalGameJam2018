using UnityEngine;
using System.Collections;

public class TriggerGenerater : MonoBehaviour
{
	public float generateInterval = 3f;
	public GameObject triggerPrefab;
	public Transform triggerRoot;

	public BlockGenerater blockGenerater;
	public CameraSplitCtrl cameraCtrl;

	float currTimeCount = 0f;

	// Update is called once per frame
	void Update ()
	{
		// timer
//		if (currTimeCount >= generateInterval) {
//			generateTrigger ();
//			currTimeCount -= generateInterval;
//		} else {
//			currTimeCount += Time.deltaTime;
//		}
	}

	public void generateTrigger(){
		GameObject triggerObj = Instantiate (triggerPrefab) as GameObject;
		triggerObj.transform.SetParent (triggerRoot);
		triggerObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
		triggerObj.layer = LayerMask.NameToLayer ("Trigger" + cameraCtrl.justAddWorldId);
		TriggerItem trigger = triggerObj.GetComponent<TriggerItem> ();
		trigger.Init (cameraCtrl.justAddWorldId);

		// generate 5 obstacle at same time
		for(int i=0; i<5; i++){
			GameObject obstacle = blockGenerater.generateBlock ();
			trigger.addObstacle (obstacle);
		}
	}
}

