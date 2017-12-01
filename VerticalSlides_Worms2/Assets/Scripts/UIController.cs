using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
    RectTransform weaponMenu;
    Vector2 startPosition;
    public float speed;


	// Use this for initialization
	void Start () {
        weaponMenu = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startPosition = transform.position;
        speed = -10f;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, speed, 0f);
        if (Input.GetMouseButtonDown(1))
        {
            transform.position = new Vector2(startPosition.x, startPosition.y);
        }
	}
}
