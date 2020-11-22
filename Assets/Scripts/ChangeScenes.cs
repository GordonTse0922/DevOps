using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public void GoToHomePage() {
        SceneManager.LoadScene(0);
    }

    public void GoToInstruction() {
        SceneManager.LoadScene(1);
    }

    public void GoToTutorial() {
        SceneManager.LoadScene(2);
    }

    public void GoToSelectStaff() {
        SceneManager.LoadScene(3);
    }

    public void GoToSelectDepolyment() {
        SceneManager.LoadScene(4);
    }

    public void GoToBigBangIntro(){
        SceneManager.LoadScene(5);
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
