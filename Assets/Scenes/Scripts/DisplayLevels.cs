using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayLevels : MonoBehaviour {

    public Button nextButton;
    public Button prevButton;
    public GameObject completeLevel;
    public GameObject incompleteLevel;

    private int[] completed = {0, 0, 0};
    private int currentPage = 0;
    private int number = 1;

    public void Start() {
        prevButton.interactable = true;
        prevButton.GetComponent<Image>().color = new Color32(255,255,255,100);

        ListLevel();
    }

    public void Update() {
        if (currentPage == 2) {
            nextButton.interactable = false;
            nextButton.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
        }
        else {
            nextButton.interactable = true;
            nextButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (currentPage == 0) {
            prevButton.interactable = false;
            prevButton.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
        }
        else {
            prevButton.interactable = true;
            prevButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

    public void nextPage() {
        if (currentPage < 2)
            currentPage++;

        ListLevel();
    }

    public void prevPage() {
        if (currentPage > 0)
            currentPage--;

        ListLevel();
    }

    private void ListLevel() {
        float x = -390;
        float y = 220;

        number = (28 * currentPage) + 1;           

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 7; j++) {
                GameObject obj = completeLevel;

                if (completed[currentPage] <= 0)
                    obj = incompleteLevel;

                GameObject level = Instantiate(obj) as GameObject;
                level.transform.position = new Vector3(x, y, 0f);
                level.transform.SetParent(this.transform, false);

                level.GetComponent<Button>().onClick.AddListener(StartGame);

                Text text = level.GetComponentInChildren<Text>();
                text.text = number.ToString();

                if (completed[currentPage] > 0)
                    completed[currentPage]--;
                
                number++;

                x += 130;
            }

            x = -390;
            y -= 130;
        }
    }

    private void StartGame() {
        SceneManager.LoadScene(4);
    }
}
