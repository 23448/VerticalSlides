using UnityEngine;

// Change the width of the viewport each time space key is pressed

public class cameraaaaaa : MonoBehaviour
{
	private Camera cam;

	void Start()
	{
		cam = Camera.main;
	}

	void Update()
	{
		if (Input.GetKey("space"))
		{
			// choose the margin randomly
			float margin = Random.Range(0.0f, 0.3f);
			// setup the rectangle
			cam.rect = new Rect(margin, 0.0f, 1.0f - margin * 2.0f, 1.0f);
		}
	}
}