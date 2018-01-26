using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraSplitCtrl : MonoBehaviour
{
	public float splitInterval = 5f;
	float currTimeCount = 0f;

	int currCameraNum = 1;

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

	// Use this for initialization
	void Start ()
	{
		initWidthAndHeights ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Q)) {
			splitCamera ();
		}
		if (Input.GetKeyUp (KeyCode.E)) {
			combineCamera ();
		}

		// timer
		if (currTimeCount >= splitInterval) {
			splitCamera ();
			currTimeCount -= splitInterval;
		} else {
			currTimeCount += Time.deltaTime;
		}
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
			break;
		case 2:
			cameraFor2.SetActive (false);
			split2Images.SetActive (false);
			cameraFor4.SetActive (true);
			split4Images.SetActive (true);
			currCameraNum = 4;
			break;
		case 4:
			cameraFor4.SetActive (false);
			split4Images.SetActive (false);
			cameraFor8.SetActive (true);
			split8Images.SetActive (true);
			currCameraNum = 8;
			break;
		case 8:
			cameraFor8.SetActive (false);
			split8Images.SetActive (false);
			cameraFor16.SetActive (true);
			split16Images.SetActive (true);
			currCameraNum = 16;
			break;
		case 16:
			Debug.Log ("already 16");
			break;
		}
	}

	public void combineCamera(){
		Debug.Log ("combine");
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
			break;
		case 8:
			cameraFor8.SetActive (false);
			split8Images.SetActive (false);
			cameraFor4.SetActive (true);
			split4Images.SetActive (true);
			currCameraNum = 4;
			break;
		case 16:
			cameraFor16.SetActive (false);
			split16Images.SetActive (false);
			cameraFor8.SetActive (true);
			split8Images.SetActive (true);
			currCameraNum = 8;
			break;
		}
	}
}

