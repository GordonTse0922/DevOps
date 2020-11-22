using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour {

	public string itemName;

    private bool moving;
	private bool movable;
	private float startPosX;
	private float startPosY;

	private Vector3 originalPos;
	private bool collided;
	private bool changePosition;

	public void Start() {
		moving = false;
		movable = true;

		originalPos = this.transform.position;
		collided = false;
		changePosition = false;
	}

	public void Update() {
		if (movable && moving) {
			Vector3 mousePos;
			mousePos = Input.mousePosition;
			mousePos = Camera.main.ScreenToWorldPoint(mousePos);

			this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
		}

		if ((collided && !moving) || changePosition) {
			this.transform.position = originalPos;
			collided = false;
			changePosition = false;
		}
	}

    public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Parent")) 
			collided = true;
	}

    private void OnMouseUp() {
		moving = false;
	}
	
	private void OnMouseDown() {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos;
			mousePos = Input.mousePosition;
			mousePos = Camera.main.ScreenToWorldPoint(mousePos);

			startPosX = mousePos.x - this.transform.localPosition.x;
			startPosY = mousePos.y - this.transform.localPosition.y;

			moving = true;
		}
	}

	public void SetPosition(Vector3 position) {
		originalPos = position;
		changePosition = true;
		movable = false;
	}

}
