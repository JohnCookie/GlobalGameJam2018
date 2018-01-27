﻿using UnityEngine;
using System.Collections;

public class GameBoot : MonoBehaviour
{
	public float splitInterval = 8f;
	float currTimeCount = 0;
	float combineTimeBonus = 3f;

	public CameraSplitCtrl cameraSplitCtrl;
	public TriggerGenerater triggerGenerator;
	public MonsterGenerator monsterGenerator;

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
}
