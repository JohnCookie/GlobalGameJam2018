using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CameraSplitCtrl : MonoBehaviour
{
	public float splitInterval = 5f;
	float currTimeCount = 0f;

	public int currCameraNum = 1;

	public List<int> currLiveWorldId = new List<int>();
	public int justAddWorldId = 1;

	public Image image1_1;

	public Image image2_1;
	public Image image2_2;

	public Image image4_1;
	public Image image4_2;
	public Image image4_3;
	public Image image4_4;

	public Image image8_1;
	public Image image8_2;
	public Image image8_3;
	public Image image8_4;
	public Image image8_5;
	public Image image8_6;
	public Image image8_7;
	public Image image8_8;

	public Image image16_1;
	public Image image16_2;
	public Image image16_3;
	public Image image16_4;
	public Image image16_5;
	public Image image16_6;
	public Image image16_7;
	public Image image16_8;
	public Image image16_9;
	public Image image16_10;
	public Image image16_11;
	public Image image16_12;
	public Image image16_13;
	public Image image16_14;
	public Image image16_15;
	public Image image16_16;

	public GameObject split1Images;
	public GameObject split2Images;
	public GameObject split4Images;
	public GameObject split8Images;
	public GameObject split16Images;

	public GameObject cameraFor1;
	public GameObject cameraFor2;
	public GameObject cameraFor4;
	public GameObject cameraFor8;
	public GameObject cameraFor16;

	public Camera camera1_1;
	public Camera camera2_1;
	public Camera camera2_2;
	public Camera camera4_1;
	public Camera camera4_2;
	public Camera camera4_3;
	public Camera camera4_4;
	public Camera camera8_1;
	public Camera camera8_2;
	public Camera camera8_3;
	public Camera camera8_4;
	public Camera camera8_5;
	public Camera camera8_6;
	public Camera camera8_7;
	public Camera camera8_8;
	public Camera camera16_1;
	public Camera camera16_2;
	public Camera camera16_3;
	public Camera camera16_4;
	public Camera camera16_5;
	public Camera camera16_6;
	public Camera camera16_7;
	public Camera camera16_8;
	public Camera camera16_9;
	public Camera camera16_10;
	public Camera camera16_11;
	public Camera camera16_12;
	public Camera camera16_13;
	public Camera camera16_14;
	public Camera camera16_15;
	public Camera camera16_16;

	// Use this for initialization
	void Start ()
	{
		initWidthAndHeights ();
		currLiveWorldId.Add (1);
	}
	
	// Update is called once per frame
	void Update ()
	{
//		if (Input.GetKeyUp (KeyCode.Q)) {
//			splitCamera ();
//		}
//		if (Input.GetKeyUp (KeyCode.E)) {
//			combineCamera ();
//		}
//
//		// timer
//		if (currTimeCount >= splitInterval) {
//			splitCamera ();
//			currTimeCount -= splitInterval;
//		} else {
//			currTimeCount += Time.deltaTime;
//		}
	}

	public int getNextWorldId(){
		for (int i = 0; i < currLiveWorldId.Count; i++) {
			if (!currLiveWorldId.Contains (1)) {
				return 1;
			}
			if (!currLiveWorldId.Contains (2)) {
				return 2;
			}
			if (!currLiveWorldId.Contains (4)) {
				return 4;
			}
			if (!currLiveWorldId.Contains (8)) {
				return 8;
			}
			if (!currLiveWorldId.Contains (16)) {
				return 16;
			}
			return 1;
		}
		return 1;
	}

	void initWidthAndHeights(){
		float totalWidth = Screen.width;
		float totalHeight = Screen.height;

		image1_1.rectTransform.sizeDelta = new Vector2 (totalWidth, totalHeight);

		image2_1.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image2_1.rectTransform.localPosition = new Vector3 (-totalWidth / 4f, 0f, 0f);
		image2_2.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image2_2.rectTransform.localPosition = new Vector3 (totalWidth / 4f, 0f, 0f);

		image4_1.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image4_1.rectTransform.localPosition = new Vector3 (-totalWidth / 4f, totalHeight/4f, 0f);
		image4_2.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image4_2.rectTransform.localPosition = new Vector3 (totalWidth / 4f, totalHeight/4f, 0f);
		image4_3.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image4_3.rectTransform.localPosition = new Vector3 (-totalWidth / 4f, -totalHeight/4f, 0f);
		image4_4.rectTransform.sizeDelta = new Vector2 (totalWidth / 2f, totalHeight / 2f);
		image4_4.rectTransform.localPosition = new Vector3 (totalWidth / 4f, -totalHeight/4f, 0f);

		image8_1.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_1.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, totalHeight/8f, 0f);
		image8_2.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_2.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, totalHeight/8f, 0f);
		image8_3.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_3.rectTransform.localPosition = new Vector3 (totalWidth / 8f, totalHeight/8f, 0f);
		image8_4.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_4.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, totalHeight/8f, 0f);
		image8_5.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_5.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, -totalHeight/8f, 0f);
		image8_6.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_6.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, -totalHeight/8f, 0f);
		image8_7.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_7.rectTransform.localPosition = new Vector3 (totalWidth / 8f, -totalHeight/8f, 0f);
		image8_8.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image8_8.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, -totalHeight/8f, 0f);

		image16_1.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_1.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, totalHeight/8f * 3f, 0f);
		image16_2.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_2.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, totalHeight/8f * 3f, 0f);
		image16_3.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_3.rectTransform.localPosition = new Vector3 (totalWidth / 8f, totalHeight/8f * 3f, 0f);
		image16_4.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_4.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, totalHeight/8f * 3f, 0f);
		image16_5.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_5.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, totalHeight/8f, 0f);
		image16_6.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_6.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, totalHeight/8f, 0f);
		image16_7.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_7.rectTransform.localPosition = new Vector3 (totalWidth / 8f, totalHeight/8f, 0f);
		image16_8.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_8.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, totalHeight/8f, 0f);
		image16_9.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_9.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, -totalHeight/8f, 0f);
		image16_10.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_10.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, -totalHeight/8f, 0f);
		image16_11.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_11.rectTransform.localPosition = new Vector3 (totalWidth / 8f, -totalHeight/8f, 0f);
		image16_12.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_12.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, -totalHeight/8f, 0f);
		image16_13.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_13.rectTransform.localPosition = new Vector3 (-totalWidth / 8f * 3f, -totalHeight/8f * 3f, 0f);
		image16_14.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_14.rectTransform.localPosition = new Vector3 (-totalWidth / 8f, -totalHeight/8f * 3f, 0f);
		image16_15.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_15.rectTransform.localPosition = new Vector3 (totalWidth / 8f, -totalHeight/8f * 3f, 0f);
		image16_16.rectTransform.sizeDelta = new Vector2 (totalWidth / 4f, totalHeight / 4f);
		image16_16.rectTransform.localPosition = new Vector3 (totalWidth / 8f * 3f, -totalHeight/8f * 3f, 0f);
	}

	public void splitCamera(){
		Debug.Log ("split");
		switch (currCameraNum) {
		case 1:
			cameraFor1.SetActive (false);
			split1Images.SetActive (false);
			cameraFor2.SetActive (true);
			split2Images.SetActive (true);
			currCameraNum = 2;

			justAddWorldId = getNextWorldId ();
			currLiveWorldId.Add (justAddWorldId);
			clearAllMask (camera2_1);
			clearAllMask (camera2_2);
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			break;
		case 2:
			cameraFor2.SetActive (false);
			split2Images.SetActive (false);
			cameraFor4.SetActive (true);
			split4Images.SetActive (true);
			currCameraNum = 4;

			justAddWorldId = getNextWorldId ();
			currLiveWorldId.Add (justAddWorldId);
			clearAllMask (camera4_1);
			clearAllMask (camera4_2);
			clearAllMask (camera4_3);
			clearAllMask (camera4_4);
			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));

			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			break;
		case 4:
			cameraFor4.SetActive (false);
			split4Images.SetActive (false);
			cameraFor8.SetActive (true);
			split8Images.SetActive (true);
			currCameraNum = 8;

			justAddWorldId = getNextWorldId ();
			currLiveWorldId.Add (justAddWorldId);
			clearAllMask (camera8_1);
			clearAllMask (camera8_2);
			clearAllMask (camera8_3);
			clearAllMask (camera8_4);
			clearAllMask (camera8_5);
			clearAllMask (camera8_6);
			clearAllMask (camera8_7);
			clearAllMask (camera8_8);
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));

			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			break;
		case 8:
			cameraFor8.SetActive (false);
			split8Images.SetActive (false);
			cameraFor16.SetActive (true);
			split16Images.SetActive (true);
			currCameraNum = 16;

			justAddWorldId = getNextWorldId ();
			currLiveWorldId.Add (justAddWorldId);
			clearAllMask (camera16_1);
			clearAllMask (camera16_2);
			clearAllMask (camera16_3);
			clearAllMask (camera16_4);
			clearAllMask (camera16_5);
			clearAllMask (camera16_6);
			clearAllMask (camera16_7);
			clearAllMask (camera16_8);
			clearAllMask (camera16_9);
			clearAllMask (camera16_10);
			clearAllMask (camera16_11);
			clearAllMask (camera16_12);
			clearAllMask (camera16_13);
			clearAllMask (camera16_14);
			clearAllMask (camera16_15);
			clearAllMask (camera16_16);
			camera16_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera16_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera16_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera16_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));

			camera16_3.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_3.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_3.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera16_5.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_5.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_5.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera16_9.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_9.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_9.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_10.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_11.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_12.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_13.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_14.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_15.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));

			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[4]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[4]));
			camera16_16.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[4]));
			break;
		case 16:
			Debug.Log ("already 16");
			break;
		}
	}

	public void combineCamera(int removeWorldId){
		Debug.Log ("combine");
		currLiveWorldId.Remove (removeWorldId);
		currTimeCount = 0f;
		switch (currCameraNum) {
		case 1:
			Debug.Log ("only 1");
			break;
		case 2:
			cameraFor2.SetActive (false);
			split2Images.SetActive (false);
			cameraFor1.SetActive (true);
			split1Images.SetActive (true);
			currCameraNum = 1;
			break;
		case 4:
			cameraFor4.SetActive (false);
			split4Images.SetActive (false);
			cameraFor2.SetActive (true);
			split2Images.SetActive (true);
			currCameraNum = 2;

			clearAllMask (camera2_1);
			clearAllMask (camera2_2);
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera2_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera2_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			break;
		case 8:
			cameraFor8.SetActive (false);
			split8Images.SetActive (false);
			cameraFor4.SetActive (true);
			split4Images.SetActive (true);
			currCameraNum = 4;

			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera4_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera4_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));

			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera4_3.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera4_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			break;
		case 16:
			cameraFor16.SetActive (false);
			split16Images.SetActive (false);
			cameraFor8.SetActive (true);
			split8Images.SetActive (true);
			currCameraNum = 8;

			clearAllMask (camera8_1);
			clearAllMask (camera8_2);
			clearAllMask (camera8_3);
			clearAllMask (camera8_4);
			clearAllMask (camera8_5);
			clearAllMask (camera8_6);
			clearAllMask (camera8_7);
			clearAllMask (camera8_8);
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle1"));
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger1"));
			camera8_1.cullingMask |= (1 << LayerMask.NameToLayer ("Monster1"));

			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_2.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));

			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_3.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_4.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));

			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_5.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_6.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_7.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));

			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[1]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[2]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Obstacle" + currLiveWorldId[3]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Trigger" + currLiveWorldId[3]));
			camera8_8.cullingMask |= (1 << LayerMask.NameToLayer ("Monster" + currLiveWorldId[3]));
			break;
		}
	}

	public void clearWorldId(int world){
		if (currLiveWorldId.Contains (world)) {
			currLiveWorldId.Remove (world);
		}
	}

	public void clearAllMask(Camera camera){
//		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Obsatcle1"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Obsatcle2"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Obsatcle4"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Obsatcle8"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Obsatcle16"));
	
//		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Trigger1"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Trigger2"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Trigger4"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Trigger8"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Trigger16"));

//		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Monster1"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Monster2"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Monster4"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Monster8"));
		camera.cullingMask &= ~(1<<LayerMask.NameToLayer("Monster16"));
	}
}

