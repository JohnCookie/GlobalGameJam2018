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

	public Material[] allColorMaterials;

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

	public void generateTrigger(int materialIndex){
		GameObject triggerObj = Instantiate (triggerPrefab) as GameObject;
		triggerObj.transform.SetParent (triggerRoot);
		triggerObj.transform.localPosition = new Vector3 (Random.Range (-9f, 9f), 0f, Random.Range (-9f, 9f));
		triggerObj.layer = LayerMask.NameToLayer ("Trigger" + cameraCtrl.justAddWorldId);
		triggerObj.transform.Find("Sphere").gameObject.layer = LayerMask.NameToLayer ("Trigger" + cameraCtrl.justAddWorldId);
		triggerObj.transform.Find("ParticleSystem").gameObject.layer = LayerMask.NameToLayer ("Trigger" + cameraCtrl.justAddWorldId);
		//triggerObj.GetComponent<Renderer> ().sharedMaterial = allColorMaterials [materialIndex];
		triggerObj.transform.Find("Sphere").GetComponent<Renderer>().sharedMaterial = allColorMaterials [materialIndex];
		ParticleSystem ps = triggerObj.GetComponentInChildren<ParticleSystem> ();
		ParticleSystem.MainModule psmain = ps.main;
		psmain.startColor = allColorMaterials [materialIndex].color;
		TriggerItem trigger = triggerObj.GetComponent<TriggerItem> ();
		trigger.Init (cameraCtrl.justAddWorldId, materialIndex);

		// generate 5 obstacle at same time
		int randomNum = Random.Range(4,7);
		for(int i=0; i<randomNum; i++){
			GameObject obstacle = blockGenerater.generateBlock (allColorMaterials[materialIndex]);
			trigger.addObstacle (obstacle);
		}
	}
}

