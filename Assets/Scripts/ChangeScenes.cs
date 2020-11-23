using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ChangeScenes : MonoBehaviour {
    
    public static int counter;
    public static int selected=0;

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

    public void GoToIntroduceDepolyment() {
        SceneManager.LoadScene(4);
    }

    public void GoToBigBangIntro(){
        counter++;
        SceneManager.LoadScene(5);
    }

    public void GoToCanaryInro(){
        counter++;
        SceneManager.LoadScene(6);
    }
    public void GoToBlueGreenInro(){
        counter++;
        SceneManager.LoadScene(7);
    }

    public void GoToDeployScene(){
        SceneManager.LoadScene(8);
    }

    public void GoToTasks(){
        SceneManager.LoadScene(9);
    }
    public void GoToGame(){
        SceneManager.LoadScene(10);
    }
    
    public void SelectedBigBang(){
        selected=1;
    }
    public void SelectedCanary(){
        selected=2;
    }
    public void SelectedBlueGreen(){
        selected=3;
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
