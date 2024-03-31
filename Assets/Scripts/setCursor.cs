using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCursor : MonoBehaviour
{
    public Texture2D crosshair;
    public Texture2D cursor;

    [SerializeField] public EscapeMenu menu;

    void Update()
    {
        if(!menu.menuActive)
        {
            Vector2 cursorOffset = new Vector2(crosshair.width/2, crosshair.height/2);

            Cursor.SetCursor(crosshair, cursorOffset, CursorMode.Auto);
        }
        else
        {
            Vector2 cursorOffset2 = new Vector2(0, 0);

            Cursor.SetCursor(cursor, cursorOffset2, CursorMode.Auto);
        }
    }
}
