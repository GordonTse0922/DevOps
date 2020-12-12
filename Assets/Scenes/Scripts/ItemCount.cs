using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCount : MonoBehaviour {

	public string[] ingredients;
	private IngredientManager script;

	public void Start() {
		script = transform.parent.gameObject.GetComponent<IngredientManager>();
	}

	public void OnTriggerEnter2D(Collider2D other) {
		for (int i = 0; i < ingredients.Length; i++) {
			if (other.gameObject.GetComponent<ItemDrag>().itemName == ingredients[i])
				script.AddIngredient(i);
		}
	}
}
