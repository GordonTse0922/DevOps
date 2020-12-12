using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public Text scoreField;
    public Transform ingredientScene;
    public Transform blankScene;

    private int score = 100;
    private int task = 0;

    void Start() {
        scoreField.text = "100";

        ingredientScene.gameObject.SetActive(false);
        blankScene.gameObject.SetActive(true);
    }

    public void AddScore() {
        score += 10;
        UpdateScore();
    }

    public void SubtractScore() {
        if (score >= 10)
            score -= 10;
        else if (score < 10)
            score = 0;

        UpdateScore();
    }

    private void UpdateScore()  {
        scoreField.text = score.ToString();
    }

    public void Next() {
        Debug.Log("next task");

        task++;

        if (task == 6) 
            SceneManager.LoadScene(5);

        if (task % 2 == 0) {
            ingredientScene.gameObject.SetActive(false);
            blankScene.gameObject.SetActive(true);

            blankScene.gameObject.GetComponent<BlankManager>().NextSet();
        }
        else {
            ingredientScene.gameObject.SetActive(true);
            blankScene.gameObject.SetActive(false);

            ingredientScene.gameObject.GetComponent<IngredientManager>().NextSet();
        }
    }
}
