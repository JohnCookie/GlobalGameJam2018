using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameBoot : MonoBehaviour
{
	public float splitInterval = 8f;
	float currTimeCount = 0;
	float combineTimeBonus = 3f;

	public CameraSplitCtrl cameraSplitCtrl;
	public TriggerGenerater triggerGenerator;
	public MonsterGenerator monsterGenerator;
	public GameObject loseObj;

	void Update(){
		if (currTimeCount >= splitInterval) {
			currTimeCount -= splitInterval;
			splitOnce ();
		} else {
			currTimeCount += Time.deltaTime;
		}
	}

	void splitOnce(){
		cameraSplitCtrl.splitCamera ();

		triggerGenerator.generateTrigger ();
		monsterGenerator.generateMonster ();
	}

	public void combineOnce(int worldId){
		cameraSplitCtrl.combineCamera (worldId);
	}

	public void showLose(){
		loseObj.SetActive (true);
		Time.timeScale = 0f;
	}
	public void backToLogo(){
		Time.timeScale = 1f;
		SceneManager.LoadScene (0);
	}
}

