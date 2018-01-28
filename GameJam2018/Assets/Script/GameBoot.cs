using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBoot : MonoBehaviour
{
	public float splitInterval = 8f;
	float currTimeCount = 2;
	float combineTimeBonus = 2f;

	public CameraSplitCtrl cameraSplitCtrl;
	public TriggerGenerater triggerGenerator;
	public MonsterGenerator monsterGenerator;
	public GameObject loseObj;
	public Text loseInfo;

	public AudioSource soundEffectSource;
	public AudioClip loseClip;
	public AudioClip splitClip;
	public AudioClip combineClip;

	List<int> alreadyUsedMaterialIndex = new List<int>();
	List<int> notUsedMaterialIndex = new List<int>();

	int splitTime = 0;
	int closedTime = 0;

	void Awake(){
		notUsedMaterialIndex.Add (0);
		notUsedMaterialIndex.Add (1);
		notUsedMaterialIndex.Add (2);
		notUsedMaterialIndex.Add (3);
		notUsedMaterialIndex.Add (4);
		notUsedMaterialIndex.Add (5);
		notUsedMaterialIndex.Add (6);
	}

	void Update(){
		if (currTimeCount >= splitInterval) {
			currTimeCount -= splitInterval;
			splitOnce ();
		} else {
			currTimeCount += Time.deltaTime;
		}
	}

	void splitOnce(){
		splitTime += 1;

		playSplitSound ();
		cameraSplitCtrl.splitCamera ();

		int index = Random.Range (0, notUsedMaterialIndex.Count);

		triggerGenerator.generateTrigger (notUsedMaterialIndex[index]);
		monsterGenerator.generateMonster (notUsedMaterialIndex[index]);

		alreadyUsedMaterialIndex.Add (notUsedMaterialIndex[index]);
		notUsedMaterialIndex.Remove (notUsedMaterialIndex[index]);
	}

	public void combineOnce(int worldId, int materialIndex){
		closedTime += 1;

		alreadyUsedMaterialIndex.Remove (materialIndex);
		notUsedMaterialIndex.Add (materialIndex);
		playCombineSound ();
		cameraSplitCtrl.combineCamera (worldId);

		currTimeCount -= combineTimeBonus;
		if (currTimeCount < 0f) {
			currTimeCount = 0f;
		}
//		Time.timeScale = 0.2f;
//		CancelInvoke ();
//		Invoke ("resetTimeScale", 0.1f);
	}

	public void resetTimeScale(){
		Time.timeScale = 1f;
	}

	public void showLose(){
		playLoseSound ();
		loseInfo.text = "The world line splited "+splitTime+" times, you closed "+closedTime+" times.";
		loseObj.SetActive (true);
		Time.timeScale = 0f;
	}
	public void backToLogo(){
		Time.timeScale = 1f;
		SceneManager.LoadScene (0);
	}

	public void playLoseSound(){
		soundEffectSource.PlayOneShot (loseClip);
	}
	public void playSplitSound(){
		soundEffectSource.PlayOneShot (splitClip);
	}
	public void playCombineSound(){
		soundEffectSource.PlayOneShot (combineClip);
	}
}

