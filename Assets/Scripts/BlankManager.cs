using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlankManager : MonoBehaviour {

    public Transform canvas;
    public GameObject[] helpSet;
    public GameObject[] instructionSet;
    public GameObject[] textSet;
    public GameObject[] blankSet;
    public GameObject[] optionSet;
    public GameObject[] animationSet;

    public int totalBlanks;
    private int countBlanks;

    private Manager script;
	private int set = 0;
    private bool created = false;

    private GameObject help;
    private GameObject animationSprite;
    private GameObject instruction;
    private GameObject text;
    private GameObject blank;
    private GameObject option;

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

            text = Instantiate(textSet[set]) as GameObject;
            text.transform.SetParent(canvas, false);

            created = true;
        }
    }

    public void Setup() {
        countBlanks = 0;

        blank = Instantiate(blankSet[set]) as GameObject;
        blank.transform.SetParent(this.transform, false);

        option = Instantiate(optionSet[set]) as GameObject;
        option.transform.SetParent(this.transform, false);
        
        animationSprite = Instantiate(animationSet[set]) as GameObject;
        animationSprite.transform.SetParent(this.transform, false);
    }

    public void NextSet() {
        set++;
        Setup();
    }

    public bool CheckAnswer(string correct, string input) {
        if (correct == input) {
            script.AddScore();
            countBlanks++;

            if (countBlanks == totalBlanks) {
                animationSprite.GetComponent<ItemAnimation>().TriggerAnimation(animationSprite);

                Destroy(help);
                Destroy(animationSprite);
                Destroy(instruction);
                Destroy(text);
                Destroy(blank);
                Destroy(option);
                created = false;
                
                script.Next();
            }

            return  true;
        }
        
        script.SubtractScore();
        return false;
    }

    public void OpenHelp() {
        if (this.gameObject.activeSelf) {
            Debug.Log("blank: open help panel");
            help.gameObject.SetActive(true);
        }
    }

}
