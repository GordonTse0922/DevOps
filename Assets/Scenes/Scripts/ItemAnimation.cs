using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnimation : MonoBehaviour {

    public Sprite[] sprites;
    private int count = 0;
    
    public void Start() {
        this.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    public void TriggerAnimation(GameObject obj) {
        if (count + 1 < sprites.Length)
            count++;

        obj.GetComponent<SpriteRenderer>().sprite = sprites[count];
    }

}
