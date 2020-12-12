using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFill : MonoBehaviour {

    public string answer;

    private BlankManager script;

	public void Start() {
		script = transform.parent.parent.gameObject.GetComponent<BlankManager>();
	}

	public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Option")) {
            string input = other.gameObject.GetComponent<ItemDrag>().itemName;
            bool correct = script.CheckAnswer(answer, input);

            if (correct)
                other.gameObject.GetComponent<ItemDrag>().SetPosition(this.transform.position);
        }
    }

}
