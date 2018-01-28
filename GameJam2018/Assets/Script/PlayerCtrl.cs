using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
	public float spd = 0.5f;
	public float jumpHeight = 5f;
	public Rigidbody bodyRigid;

	public GameBoot gameBoot;
	public MonsterGenerator monsterGenerator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump")) {
			Debug.Log ("Jump");
			bodyRigid.velocity = new Vector3 (bodyRigid.velocity.x, jumpHeight, bodyRigid.velocity.z);
		}
		bodyRigid.velocity = new Vector3 (Input.GetAxis ("Horizontal") * spd, bodyRigid.velocity.y, Input.GetAxis ("Vertical") * spd);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Monster") {
			gameBoot.showLose ();
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Trigger") {
			TriggerItem item = col.gameObject.GetComponent<TriggerItem> ();
			item.destroyRelatedObstacle ();

			Destroy (col.gameObject);
			monsterGenerator.removeMonsterByWorld (item.matIndex);

			gameBoot.combineOnce (item.worldId, item.matIndex);
		}
	}
}
