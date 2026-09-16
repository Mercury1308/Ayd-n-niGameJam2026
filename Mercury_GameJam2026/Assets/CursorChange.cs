

using UnityEngine;

public class CursorChange : MonoBehaviour
{

    public Texture2D handCursor;   // el cursoru
    public Texture2D defaultCursor;
    private Vector2 hotspot = Vector2.zero;


    void Start()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }


    void OnMouseEnter()
    {
        Cursor.SetCursor(handCursor, hotspot, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }
}

/*
using UnityEngine;

public class CursorChange : MonoBehaviour
{
    public Texture2D handCursor;
    Vector2 hotspot;

    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseEnter()
    {
        Vector2 hotspot = new Vector2(handCursor.width / 2, handCursor.height / 2);
        Cursor.SetCursor(handCursor, hotspot, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    */
/*
using UnityEngine;

public class CursorChange : MonoBehaviour
{
public Texture2D handCursor;
Vector2 hotspot;

void Start()
{
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;

    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
}

void OnMouseEnter()
{
    hotspot = new Vector2(handCursor.width / 2, handCursor.height / 2);
    Cursor.SetCursor(handCursor, hotspot, CursorMode.Auto);
}

void OnMouseExit()
{
    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
}
}
*/

