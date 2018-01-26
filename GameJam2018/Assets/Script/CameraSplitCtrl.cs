using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraSplitCtrl : MonoBehaviour
{
	public float splitInterval = 5f;

	public Image image1_1;

	public Image image2_1;
	public Image image2_2;

	public Image image4_1;
	public Image image4_2;
	public Image image4_3;
	public Image image4_4;

	// Use this for initialization
	void Start ()
	{
		initWidthAndHeights ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Q)) {
			Debug.Log ("split");
		}
		if (Input.GetKeyUp (KeyCode.E)) {
			Debug.Log ("combine");
		}

		// timer
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

	}

	public void splitCamera(){
			
	}

	public void combineCamera(){
	
	}
}

