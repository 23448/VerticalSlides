using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour {
    public Texture2D cursor;
    public CursorMode auto = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;

	// Use this for initialization
	void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, hotspot, auto);
	}

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, auto);
    }
}
