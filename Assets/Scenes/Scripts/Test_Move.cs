using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Move : MonoBehaviour {

    private Vector2 screenPoint;
    private Vector2 offset;

    private bool dragging;

    // public void OnMouseDown()
    // {
    //     Debug.Log("Clicked");
    //     screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //     offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    // }
    public  void OnPointerDown() {
        dragging = true;
        // Debug.Log("Ready to drag");
        // screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        // offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    public  void OnPointerUp() {
        dragging = false;
    }

    public void OnMouseDrag()
    {
        if(dragging){
        Debug.Log("Dragged");
        // Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        // Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        // transform.position = curPosition;
        if (dragging) {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        }
    }
}