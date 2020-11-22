using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour {

    public Transform canvas;
    public GameObject[] helpSet;
    public GameObject[] containerSet;
    public GameObject[] ingredientSet;
    public GameObject[] instructionSet;

    private Manager script;
    private bool created = false;

	private int set = -1;
    private int[] counter;
    private int[] limiter;

    private GameObject help;
    private GameObject container;
    private GameObject ingredients;
    private GameObject instruction;

    public void Start() {
        script = transform.parent.gameObject.GetComponent<Manager>();
        Setup();
    }

    public void Update() {
        if (!created && this.gameObject.activeSelf) {
            help = Instantiate(helpSet[set]) as GameObject;
            help.transform.SetParent(canvas, false);
            help.gameObject.SetActive(false);

            instruction = Instantiate(instructionSet[set]) as GameObject;
            instruction.transform.SetParent(canvas, false);

            created = true;
        }
    }

    public void Setup() {
        if (set == 0)
            limiter = new int[] {2, 2, 1, 1, 2, 1};
        else if (set == 1)
            limiter = new int[] {3};
        else 
            limiter = new int[] {1};

        counter = new int[limiter.Length];
		for (int i = 0; i < counter.Length; i++) 
			counter[i] = 0;

        container = Instantiate(containerSet[set]) as GameObject;
        container.transform.SetParent(this.transform, false);

        ingredients = Instantiate(ingredientSet[set]) as GameObject;
        ingredients.transform.SetParent(this.transform, false);
    }

    public void NextSet() {
        set++;
        Setup();
    }

    public void AddIngredient(int index) {
        counter[index]++;
        
        if (counter[index] > limiter[index])
            script.SubtractScore();
        else {
            script.AddScore();
            container.GetComponent<ItemAnimation>().TriggerAnimation(container);
        }

        if (Completed()) {
            Destroy(help);
            Destroy(container);
            Destroy(ingredients);
            Destroy(instruction);
            created = false;

            script.Next();
        }
    }

    private bool Completed() {
        for (int i = 0; i < limiter.Length; i++) 
            if (counter[i] != limiter[i]) 
                return false;

        return true;
    }

    public void OpenHelp() {
        if (this.gameObject.activeSelf) {
            Debug.Log("ingredient: open help panel");
            help.gameObject.SetActive(true);
        }
    }

}
